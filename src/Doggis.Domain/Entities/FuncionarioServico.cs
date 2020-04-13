using System;

namespace Doggis.Domain.Entities
{
    public class FuncionarioServico : EntityBase
    {
        public Guid FuncionarioId { get; set; }

        public Guid ServicoId { get; set; }
    }
}