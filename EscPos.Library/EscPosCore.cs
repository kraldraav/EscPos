using System.Net;
using System.Net.Sockets;
using EscPos.Library.Base;
using EscPos.Library.Base.Commands;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EscPos.Library
{
    /// <summary> Main class for interaction </summary>
    public class EscPosCore
    {
        public string IpAddress { get; private set; }
        public int Port { get; private set; }

        public EscPosCore(string ipAddress, int port)
        {
            IpAddress = ipAddress;
            Port = port;
        }

        public void SendCommand(byte[] command)
        {
            using (var client = new TcpClient(IpAddress, Port))
                using (NetworkStream stream = client.GetStream())
                {
                    try
                    {
                        stream.Write(command, 0, command.Length);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }

                }
        }
    }
}