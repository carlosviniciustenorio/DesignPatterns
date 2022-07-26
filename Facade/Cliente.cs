using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public bool ClienteTemNomeSujo() => string.IsNullOrEmpty(Nome);
    }
}