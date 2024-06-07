using System.ComponentModel.DataAnnotations;

namespace BlueRewards.Models
{
	public class Empresa
	{
		[Key]
		public int EmpresaId { get; set; }
		[Required]
		public string Cnpj {  get; set; }
		[Required]
		public string Nome { get; set; }
	}
}
