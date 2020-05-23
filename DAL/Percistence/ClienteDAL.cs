using DAL.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Percistence
{
    public class ClienteDAL : Conexao
    {
        public void Insert(Cliente dados)
        {
            try
            {
                Conectar();
                command = new SqlCommand("INSERT INTO Cliente (Nome, Email, Endereco) VALUES (@nome, @email, @endereco)", connection);

                command.Parameters.AddWithValue("@nome", dados.Nome);
                command.Parameters.AddWithValue("@email", dados.Email);
                command.Parameters.AddWithValue("@endereco", dados.Endereco);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar cliente." + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Update(Cliente dados)
        {
            try
            {
                Conectar();
                command = new SqlCommand("UPDATE Cliente SET Nome=@nome, Email=@email, Endereco=@endereco WHERE Id=@id", connection);

                command.Parameters.AddWithValue("@nome", dados.Nome);
                command.Parameters.AddWithValue("@email", dados.Email);
                command.Parameters.AddWithValue("@endereco", dados.Endereco);
                command.Parameters.AddWithValue("@id", dados.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar dados do cliente." + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("DELETE FROM Cliente WHERE Id=@id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar os dados do cliente." + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public Cliente SelecionarCliente(int id)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Cliente WHERE Id=@id", connection);

                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();

                Cliente dados = null;

                while (reader.Read())
                {
                    dados = new Cliente();

                    dados.Id        = Convert.ToInt32(reader["Id"]);
                    dados.Nome      = reader["Nome"].ToString();
                    dados.Email     = reader["Email"].ToString();
                    dados.Endereco  = reader["Endereco"].ToString();
                }
                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar cliente." + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<Cliente> Select()
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Cliente", connection);

                reader = command.ExecuteReader();

                List<Cliente> cliente = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente dados = new Cliente();

                    dados.Id        = Convert.ToInt32(reader["Id"]);
                    dados.Nome      = reader["Nome"].ToString();
                    dados.Email     = reader["Email"].ToString();
                    dados.Endereco  = reader["Endereco"].ToString();

                    cliente.Add(dados);
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar clientes." + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
