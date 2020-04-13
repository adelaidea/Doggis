using System;
using System.Collections.Generic;

namespace Doggis.Domain.Entities
{
    public class Funcionario : EntityBase
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Registro { get; set; }

        public virtual IEnumerable<FuncionarioServico> Servicos { get; set; }

        public virtual IEnumerable<FuncionarioTipoPet> TiposPet { get; set; }
    }
}
