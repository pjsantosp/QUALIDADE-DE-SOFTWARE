using System.Data.Entity.ModelConfiguration;

namespace Atendimento.Hospitalar.Models
{
    public class AtendimentoConfiguration : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoConfiguration()
        {
            ToTable("Atendimento");
            HasKey(e => e.AtendimentoId);
            Property(e => e.Data).HasColumnType("DateTime");

            HasMany(e => e.ListaDeServico)
                  .WithMany(e => e.ListaDeAtendimento)
                  .Map(e =>
                      {
                          e.MapLeftKey("AtendimentoId");
                          e.MapRightKey("ServicoId");
                          e.ToTable("ItemDoAtendimento");
                      });
        }
    }
}