using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Percistence
{
    public class Conexao
    {
        protected SqlCommand command;
        protected SqlConnection connection;
        protected SqlDataReader reader;

        public void Conectar()
        {
            try
            {
                connection = new SqlConnection("Data Source=DESKTOP-RK5RDS8;Initial Catalog=master;Integrated Security=True");
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    
}
