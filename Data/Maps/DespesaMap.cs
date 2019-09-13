using Bankastico.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bankastico.Data.Maps
{
	public class DespesaMap : IEntityTypeConfiguration<Despesa>
	{
		public void Configure(EntityTypeBuilder<Despesa> builder)
		{
			builder.ToTable("Despesa");
			builder.HasKey(d => d.Id);
			builder.Property(d => d.Titulo).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
			builder.Property(d => d.Descricao).HasMaxLength(200).HasColumnType("varchar(200)");
			builder.Property(d => d.Valor).IsRequired().HasColumnType("money");
			builder.HasOne(d => d.Categoria).WithMany(c => c.Despesas).HasForeignKey(d => d.IdCategoria).IsRequired();
		}
	}
}