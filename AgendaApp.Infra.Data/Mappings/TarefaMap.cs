using AgendaApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApp.Infra.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id);
            builder.Property(t=> t.Nome).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Data).IsRequired();
            builder.Property(t=> t.Hora).IsRequired();
            builder.Property(t=> t.Prioridade).IsRequired();
            builder.Property(t=> t.Ativo).IsRequired();

            #region relacionaemntos
            builder.HasOne(t=> t.Usuario)
                .WithMany(u=> u.Tarefas)
                .HasForeignKey(t=> t.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict); //não precisava pois o default já é restrict
            #endregion
        }
    }
}
