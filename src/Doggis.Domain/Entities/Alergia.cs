namespace Doggis.Domain.Entities
{
    public class Alergia : EntityBase
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
