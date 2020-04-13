namespace Doggis.Domain.Entities
{
    public class Raca : EntityBase
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual TipoPet TipoPet { get; set; }

        public int TipoPetId { get; set; }
    }
}
