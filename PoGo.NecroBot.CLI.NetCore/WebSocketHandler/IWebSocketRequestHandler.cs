using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler
{
    interface IWebSocketRequestHandler
    {
        string Command { get; }
        Task Handle(ISession session,  dynamic message);
    }
}
