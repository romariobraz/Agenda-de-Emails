using Agenda.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Agenda.DBServices
    {
        public class PostgresDatabaseService : IDatabaseService
        {
            #region BD
            //Passando a string para conexão e apontando ela.
            private readonly string _connectionString;

            public PostgresDatabaseService(string connectionString)
            {
                _connectionString = connectionString;
            }

            //Testar a conexão com o BD
            public bool TestarConexao()
            {
                try
                {
                    using var conexao = new NpgsqlConnection(_connectionString);
                    conexao.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            //Criação das tabelas
            public void CriarTabelaContatos()
            {
                using var conexao = new NpgsqlConnection(_connectionString);
                conexao.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS contatos(
                              Id SERIAL PRIMARY KEY,
                              Nome VARCHAR(60),
                              Email VARCHAR(60)
                           );";
                using var cmd = new NpgsqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            #endregion

            #region Validações
            public void ValidarContato(string nome)
            {
            if (string.IsNullOrWhiteSpace(nome))
                {
                throw new ArgumentException("Nome e Email são obrigatórios");
                }
            }

            public void ValidarFormatoEmail(string email)
            {
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") || string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email inválido");
            }
            //Centralizei as validações
            public void ValidaInformacoes(string nome, string email)
            {
            ValidarContato(nome);
            ValidarFormatoEmail(email);
            }
            #endregion

            #region Operações nos bancos de dados

            public void InserirContato(string nome, string email)
            {
            ValidaInformacoes(nome, email);

            using var conexao = new NpgsqlConnection(_connectionString);
            using var cmd = new NpgsqlCommand("INSERT INTO contatos (Nome, Email) VALUES (@nome, @email)", conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);

            conexao.Open();
            cmd.ExecuteNonQuery();
            }

            public List<Contato> BuscarContatos(string filtroNome = null)
            {

                using var conexao = new NpgsqlConnection(_connectionString);

                conexao.Open();

                string sql = "SELECT * FROM contatos";
                if (!string.IsNullOrWhiteSpace(filtroNome))
                    sql += " WHERE Nome ILIKE @nome";

                using var cmd = new NpgsqlCommand(sql, conexao);
                if (!string.IsNullOrWhiteSpace(filtroNome))
                    cmd.Parameters.AddWithValue("@nome", "%" + filtroNome + "%");

                var reader = cmd.ExecuteReader();
                var contatos = new List<Contato>();
                while (reader.Read())
                {
                    contatos.Add(new Contato
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Nome = reader.GetString(reader.GetOrdinal("Nome")),
                        Email = reader.GetString(reader.GetOrdinal("Email"))
                    });
                }
                return contatos;
            }

            public void ExcluirContato(int id)
            {
                using var conexao = new NpgsqlConnection(_connectionString);
                conexao.Open();
                string sql = "DELETE FROM contatos WHERE Id = @id";
                using var cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            
            public void AtualizarContato(int id, string nome, string email)
            {
                ValidaInformacoes(nome, email);
                
                using var conexao = new NpgsqlConnection(_connectionString);
                conexao.Open();
                string sql = "UPDATE contatos SET Nome=@nome, Email=@email WHERE Id=@id";
                using var cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            }
            #endregion
        }

}
