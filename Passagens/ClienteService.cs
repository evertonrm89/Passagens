using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            try
            {
                dao.add(c);
                return true;
            }
            catch
            {
                //Salvar Log
            }

            return false;

        }

        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return (Cliente) dao.Buscar(nome);
        }
    }


}
