namespace HW.Business.Interfaces
{
    public interface IMessageRepository
    {
        string GetMessage();

        void WriteMessage();
    }
}
