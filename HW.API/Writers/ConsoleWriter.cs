using HW.Business.Interfaces;
using System;

namespace HW.API.Writers
{
    public class ConsoleWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
