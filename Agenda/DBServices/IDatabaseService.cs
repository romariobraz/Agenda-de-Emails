using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Agenda.Models;

namespace Agenda.DBServices
{
    public interface IDatabaseService
    {
            bool TestarConexao();
            void CriarTabelaContatos();
            void InserirContato(string nome, string email);
            List<Contato> BuscarContatos(string filtroNome = null);
            void ExcluirContato(int id);
            void AtualizarContato(int id, string nome, string email);
     
    }
}
