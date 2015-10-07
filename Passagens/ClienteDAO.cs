using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    class ClienteDAO
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public void add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();

            return (Cliente) resultado;
        }
    }
}
