using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.ToTable("Categorias");

            builder.HasMany(c => c.Produtos) //Categoria tem muitos Produtos
                .WithOne(p => p.Categoria) //Produtos tem só uma Categoria
                .HasForeignKey(p => p.CategoriaId); //Estão ligados por Chave Estrangeira no Produto
        }
    }
}
