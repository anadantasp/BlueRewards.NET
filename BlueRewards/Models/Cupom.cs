using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueRewards.Models
{
	public class Cupom
	{
		[Key]
		public int CupomId { get; set; }
		public string Descricao { get; set; }
		public string Codigo { get; set; }
		public DateTime Validade { get; set; }
		public int Pontuacao { get; set; }
		[ForeignKey("EmpresaId")]
		public Empresa Empresa { get; set; }
	}
}
