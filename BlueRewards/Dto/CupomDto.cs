using BlueRewards.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlueRewards.Dto
{
	public class CupomDto
	{
		[Required]
		public string Descricao { get; set; }
		[Required]
		public string Codigo { get; set; }
		[Required]
		public DateTime Validade { get; set; }
		[Required]
		public int Pontuacao { get; set; }
		[Required]
		public int EmpresaId { get; set; }
	}
}
