using AppCore.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DevApp.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(e => e.CEP)
               .IsRequired()
               .HasColumnType("varchar(10)");

            builder.Property(e => e.Complemento)
              .HasColumnType("varchar(250)");

            builder.Property(e => e.Bairro)
               .IsRequired()
              .HasColumnType("varchar(100)");

            builder.ToTable("Enderecos");
        }
    }
}
