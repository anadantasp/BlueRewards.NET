using System.ComponentModel.DataAnnotations;

namespace BlueRewards.Models
{
	public class Empresa
	{
		[Key]
		public int EmpresaId { get; set; }
		public string Cnpj {  get; set; }
		public string Nome { get; set; }
	}
}
