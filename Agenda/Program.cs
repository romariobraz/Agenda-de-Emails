using Agenda.DBServices;

namespace Agenda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();            

            string conexao = "server=localhost;username=postgres;password=*****;database=contatos";

            IDatabaseService dbService = new PostgresDatabaseService(conexao);

            ApplicationConfiguration.Initialize();

            Application.Run(new Agenda(dbService));
        }
    }
}