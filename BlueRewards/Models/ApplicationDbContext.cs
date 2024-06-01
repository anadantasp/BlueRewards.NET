using Microsoft.EntityFrameworkCore;

namespace BlueRewards.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Cupom> Cupons { get; set; }
	}
}
