using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        Banco banco = new("Inter", true);
        Credito credito = new();
        Agencia agencia = new();

        public bool PodeEfetuarFinanciamento(Cliente cliente)
        {
            if(banco.BancoAtivo(banco) && 
               credito.ContemCredito(cliente) &&
               agencia.VeiculoDisponivel() &&
               !cliente.ClienteTemNomeSujo())
               return true;

            return false;
        }
    }
}