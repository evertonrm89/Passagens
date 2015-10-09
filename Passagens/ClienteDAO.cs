using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    class ClienteDAO
    {
        public static List<Cliente> clientes = new List<Cliente>();
        //private static string connectionString = "Data Source=.\\MSSQLSERVER2014;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER2014\\MSSQL\\DATA\\passagens.mdf;Integrated Security=True; Connect Timeout=30;User Instance=True;";

        private static string connectionString = "data source=.\\MSSQLSERVER2014;Integrated Security=SSPI;Database=passagens";

            SqlConnection sqlConn = new SqlConnection(connectionString);


        public void add(Cliente c)
        {
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.clientes (nome, cpf) values ("+"'"+ c.Nome +"', "+"'"+c.Cpf+"')", sqlConn);
            cmd.ExecuteNonQuery();
            //ClienteDAO.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            Cliente cliente = new Cliente();

            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM clientes where nome = "+"'"+nome+"'", sqlConn);
            SqlDataReader dr =  cmd.ExecuteReader();

            while(dr.Read()){
                cliente.Nome = dr["nome"].ToString();
                cliente.Cpf = dr["cpf"].ToString();
            }

            sqlConn.Close();

            //var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();

            return cliente;
        }

        public List<Cliente> getClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM clientes", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = dr["nome"].ToString();
                cliente.Cpf = dr["cpf"].ToString();

                clientes.Add(cliente);
            }

            sqlConn.Close();

            //var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();

            return clientes;

        }
    }
}
