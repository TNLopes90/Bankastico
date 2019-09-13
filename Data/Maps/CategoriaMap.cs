using Bankastico.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bankastico.Data.Maps
{
	public class CategoriaMap : IEntityTypeConfiguration<Categoria>
	{
		public void Configure(EntityTypeBuilder<Categoria> builder)
		{
			builder.ToTable("Categoria");
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Titulo).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
		}
	}
}