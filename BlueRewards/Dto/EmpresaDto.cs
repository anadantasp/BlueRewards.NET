using System.ComponentModel.DataAnnotations;

namespace BlueRewards.Dto
{
	public class EmpresaDto
	{
		public string Cnpj { get; set; }
		[Required]
		[Display(Name = "Empresa")]
		public string Nome { get; set; }
	}
}
