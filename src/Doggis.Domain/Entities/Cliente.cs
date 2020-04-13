using System;
using System.Collections.Generic;

namespace Doggis.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente()
        { }

        public Cliente(string nome, string rg, string cpf, string email, string endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            RG = rg;
            CPF = cpf;
            Email = email;
            Endereco = endereco;
        }

        public Cliente(string nome, string rg, string cpf, string email, string endereco, int pontosAcumulados)
            : this(nome, rg, cpf, email, endereco)
        {
            PontosAcumulados = pontosAcumulados;
        }

        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string RG { get; protected set; }

        public string CPF { get; protected set; }

        public string Email { get; protected set; }

        public string Endereco { get; protected set; }

        public int PontosAcumulados { get; protected set; }

        public virtual IEnumerable<Pet> Pet { get; set; }
    }
}