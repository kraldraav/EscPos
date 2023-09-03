using System.Text;
using EscPos.Library;
using EscPos.Library.Base.Commands;
using EscPos.Library.Base.Enums;

namespace EscPos.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, EscPos Library!");

            var escPosCore = new EscPosCore("127.0.0.1", 9100);

            escPosCore.SendCommand(Encoding.UTF8.GetBytes("Hello, EscPos Library!"));
            escPosCore.SendCommand(PrintCommands.PrintAndFeedNLines(10));
        }
    }
}