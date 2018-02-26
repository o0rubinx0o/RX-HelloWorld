using HW.Business.Interfaces;
using HW.Business.Services;

namespace HW.Business.BaseRepositories
{
    public abstract class MessageRepository : IMessageRepository
    {
        public static string Message;

        protected MessageRepository()
        {
            var service = new HelloWorldService();
            Message = service.GetMessage();
        }

        public string GetMessage()
        {
            return Message;
        }

        public virtual void WriteMessage()
        {

        }
    }
}
