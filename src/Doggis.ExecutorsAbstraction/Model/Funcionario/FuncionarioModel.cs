using System;

namespace Doggis.ExecutorsAbstraction.Model.Funcionario
{
    public class FuncionarioModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Registro { get; set; }
    }
}
