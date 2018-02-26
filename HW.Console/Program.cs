using HW.API;
using HW.API.Repositories;
using System.Configuration;


namespace HW.Console
{
    public class Program
    {

        private static void Main()
        {
            var writerType = ConfigurationManager.AppSettings["MessageWriter"];

            var writer = new WriterService().GetWriter(writerType);

            var repository = new ConsoleMessageRepository(writer);

            repository.WriteMessage();

            System.Console.ReadLine();
        }
    }
}
