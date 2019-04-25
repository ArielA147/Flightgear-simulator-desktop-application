using System.Net.Sockets;

namespace Model
{
    public interface IClientHandler
    {
        void HandleClient(TcpClient client);
    }
}
