using BlueRewards.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlueRewards.Dto
{
	public class CupomDto
	{
		[Required]
		public string Descricao { get; set; }
		public DateTime Validade { get; set; }
		[Required]
		public int Pontuacao { get; set; }
		public int EmpresaId { get; set; }
	}
}
