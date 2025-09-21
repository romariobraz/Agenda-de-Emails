using Agenda.DBServices;

namespace Agenda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();            

            string conexao = "server=localhost;username=postgres;password=9363plM!;database=contatos";

            IDatabaseService dbService = new PostgresDatabaseService(conexao);

            ApplicationConfiguration.Initialize();

            Application.Run(new Agenda(dbService));
        }
    }
}