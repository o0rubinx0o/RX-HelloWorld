using HW.API.Writers;
using HW.Business.Interfaces;

namespace HW.API
{
    public class WriterService
    {
        public IMessageWriter GetWriter(string writerType)
        {
            switch (writerType)
            {
                case "Console":
                    return new ConsoleWriter();

                case "Database":
                    return new DatabaseWriter();
                default:
                    return new DefaultWriter();
            }
        }
    }
}
