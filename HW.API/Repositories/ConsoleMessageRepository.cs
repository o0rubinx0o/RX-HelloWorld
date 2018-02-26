using HW.API.Writers;
using HW.Business.BaseRepositories;
using HW.Business.Interfaces;

namespace HW.API.Repositories
{
    public class ConsoleMessageRepository : MessageRepository
    {
        public readonly IMessageWriter Writer;

        public ConsoleMessageRepository(IMessageWriter writer = null)
        {
            Writer = writer ?? new DefaultWriter();
        }

        public override void WriteMessage()
        {
            Writer.WriteMessage(Message);
        }
    }
}
