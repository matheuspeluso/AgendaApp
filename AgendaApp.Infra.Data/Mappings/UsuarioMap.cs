using AgendaApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApp.Infra.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Usuário
    /// </summary>
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u=> u.Id);
            builder.Property(u=> u.Nome).HasMaxLength(150).IsRequired();
            builder.Property(u=> u.Email).HasMaxLength(50).IsRequired();
            builder.Property(u=> u.Senha).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Ativo).IsRequired();

            builder.HasIndex(u => u.Email).IsUnique();
            //não precisa criar o relacionamento aqui apenas onde fica a cheve estrangeira
        }
    }
}
