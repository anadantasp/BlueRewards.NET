using BlueRewards.Models;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;


namespace BlueRewards.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Cupom> Cupons { get; set; }

		
	}
}


