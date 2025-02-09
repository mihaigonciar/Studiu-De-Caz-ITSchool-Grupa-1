using StudiuDeCaz1.Backend;

namespace StudiuDeCaz1.Frontend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Asta ar fi inlocuita de incarcarea unui set de date stocat.
            PopulateMockupData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());

            // Aici ar fi un loc posibil de salvare a datelor noi pentru urmatoarea sesiune.
        }

        private static void PopulateMockupData()
        {
            ContactFactory.AddNewContact("Mihai G.", "+40712345678", "mihai@example.com", "Str. Exemplului 1", "Cluj-Napoca");
            ContactFactory.AddNewContact("Maria A.", "+40723456789", "maria@example.com", "Str. Lorem 2", "Focsani");
            ContactFactory.AddNewContact("Andrei B.", "+40734567890", "andrei@example.com", "Str. Ipsum 3", "Galati");
            ContactFactory.AddNewContact("Raluca C.", "+40745678901", "raluca@example.com", "Str. Exemplului 4", "Timisoara");
            ContactFactory.AddNewContact("Matei D.", "+40756789012", "matei@example.com", "Str. Lorem 5", "Suceava");
            ContactFactory.AddNewContact("Alexandra E.", "+40767890123", "alexandra@example.com", "Str. Ipsum 6", "Brasov");
        }
    }
}