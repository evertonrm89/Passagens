using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            try
            {
                dao.add(c);
            }
            catch
            {
              
            }

        }

        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return (Cliente) dao.Buscar(nome);
        }
    }


}
