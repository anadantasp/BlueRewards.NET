using BlueRewards.Dto;
using BlueRewards.Models;
using BlueRewards.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueRewards.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CupomController : ControllerBase
	{
		public readonly ApplicationDbContext _dbContext;

		public CupomController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var cupons = await _dbContext.Cupons.Include(a => a.Empresa).ToListAsync();
			return Ok(cupons);

		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id)
		{
			var cupom = await _dbContext.Cupons.Include(a => a.Empresa).FirstOrDefaultAsync(c => c.CupomId == id);
			if (cupom == null)
			{
				return NotFound();
			}

			return Ok(cupom);
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CupomDto cupomDto)
		{
			if (ModelState.IsValid)
			{
				Cupom cupom = new Cupom();
				cupom.Descricao = cupomDto.Descricao;
				cupom.Codigo = cupomDto.Codigo;
				cupom.Validade = cupomDto.Validade;
				cupom.Pontuacao = cupomDto.Pontuacao;
				cupom.Empresa = _dbContext.Empresas.Find(cupomDto.EmpresaId);

				_dbContext.Cupons.Add(cupom);
				await _dbContext.SaveChangesAsync();
				return CreatedAtAction(nameof(GetById), new { id = cupom.CupomId }, cupom);

			}
			return BadRequest();

		}

		[HttpDelete("{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			var cupom = await _dbContext.Cupons.FindAsync(id);
			if (cupom == null)
			{
				return NotFound();
			}

			_dbContext.Cupons.Remove(cupom);
			await _dbContext.SaveChangesAsync();
			return Ok(cupom);
		}
	}
}
