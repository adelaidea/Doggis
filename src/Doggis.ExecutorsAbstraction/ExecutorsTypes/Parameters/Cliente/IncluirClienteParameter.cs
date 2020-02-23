using System;
using System.Collections.Generic;
using System.Text;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente
{
    public class IncluirClienteParameter : ParameterBase
    {
        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string  Email { get; set; }

        public string Endereco { get; set; }    
    }
}
