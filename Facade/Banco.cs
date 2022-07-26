using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Banco
    {
        public string Nome { get; private set; }
        public bool Ativo { get; set; }

        public Banco(string nome, bool ativo)
        {
            Nome = nome;
            Ativo = ativo;
        }

        public bool BancoAtivo(Banco banco) => banco.Ativo;
    }
}