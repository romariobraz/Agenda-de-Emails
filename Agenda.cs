using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;


namespace _34.Bases_de_dados
{
    public partial class Agenda : Form
    {
        public string SqlConect = "server=127.0.0.1;uid=root;pwd=9363plM!;database=contatos";
        public Agenda()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(SqlConect);

            try
            {
                conexao.Open();
                lbResultado.Text = "Conectado";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                //Comando para criar a database
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS contatos";
                //Executa o comando para criação  da database
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                lbResultado.Text = "Não Conectado";
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCriarTabelas_Click(object sender, EventArgs e)
        {
            // SqlConect
            MySqlConnection conexao = new MySqlConnection(SqlConect);

            try
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "CREATE TABLE contatos( Id INT NOT NULL AUTO_INCREMENT, Nome VARCHAR(60), Email VARCHAR(60), PRIMARY KEY(Id))";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tabela Criada com sucesso.");
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(SqlConect);

            try
            {
                conexao.Open();

                string nome = txbNome.Text;
                string email = txbEmail.Text;

                string inserir = "INSERT INTO contatos (Nome, Email) VALUES (@nome, @email)";
                using (var cmd = new MySqlCommand(inserir, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro Adicionado com sucesso!");

            }
            catch (Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
                txbEmail.Clear();
                txbNome.Clear();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();

            using (var conexao = new MySqlConnection(SqlConect))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM contatos";
                    if (!string.IsNullOrWhiteSpace(txbNome.Text))
                    {
                        query += " WHERE Nome LIKE @nome";
                    }

                    DataTable dados = new DataTable();
                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        if (!string.IsNullOrWhiteSpace(txbNome.Text))
                        {
                            cmd.Parameters.AddWithValue("@nome", "%" + txbNome.Text + "%");
                        }

                        using (var adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(dados);
                        }
                    }

                    foreach (DataRow row in dados.Rows)
                    {
                        dgvLista.Rows.Add(row.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    dgvLista.Rows.Clear();
                    lbResultado.Text = ex.Message;
                }
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(SqlConect);

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                int id = (int)dgvLista.SelectedRows[0].Cells[0].Value;

                cmd.CommandText = "DELETE FROM contatos WHERE Id = '" + id + "'";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Deletado com sucesso!");

            }
            catch (Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
                txbEmail.Clear();
                txbNome.Clear();
                btnProcurar_Click(sender, e);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(SqlConect);

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                string nome = txbNome.Text;
                string email = txbEmail.Text;

                int id = (int)dgvLista.SelectedRows[0].Cells[0].Value;

                cmd.CommandText = "UPDATE contatos SET Nome = @nome, Email = @email WHERE Id = @id";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Atualziado com sucesso!");

            }
            catch (Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
                txbEmail.Clear();
                txbNome.Clear();
                btnProcurar_Click(sender, e);
            }
        }
    }
}
