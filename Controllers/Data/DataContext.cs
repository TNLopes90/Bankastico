using Microsoft.EntityFrameworkCore;
using Bankastico.Model;
using Bankastico.Data.Maps;

namespace Bankastico.Data
{
		public class DataContext : DbContext
		{
			public DbSet<Despesa> Despesas { get; set; }
			public DbSet<Categoria> Categorias { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseInMemoryDatabase();
			}

			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				modelBuilder.ApplyConfiguration(new DespesaMap());
				modelBuilder.ApplyConfiguration(new CategoriaMap());
			}
		}
}