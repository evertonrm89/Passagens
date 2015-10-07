using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
            ClienteDAO dao = new ClienteDAO();
            dao.add(c);

            return true;
        }

        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return (Cliente) dao.Buscar(nome);
        }

        public List<Cliente> getClientes()
        {
            return ClienteDAO.clientes;
        }
    }


}
