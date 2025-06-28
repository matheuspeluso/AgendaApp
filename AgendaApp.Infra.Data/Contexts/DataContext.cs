using AgendaApp.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AgendaApp.Infra.Data.Contexts
{
    /// <summary>
    ///     Classe de contexto para conexão com o banco de dados
    /// </summary>
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1434;Initial Catalog=master;User ID=sa;Password=Coti@2025;Encrypt=False");//mapeando a string de conexão
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
        }
    }
}