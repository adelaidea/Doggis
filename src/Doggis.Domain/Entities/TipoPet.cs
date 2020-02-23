namespace Doggis.Domain.Entities
{
    public class TipoPet : EntityBase
    {
        public TipoPet()
        { }

        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
