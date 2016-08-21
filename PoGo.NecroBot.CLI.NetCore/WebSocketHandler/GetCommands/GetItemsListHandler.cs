using System.Threading.Tasks;
using PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler.GetCommands
{
    class GetItemsListHandler : IWebSocketRequestHandler
    {
        public string Command { get; private set; }

        public GetItemsListHandler()
        {
            Command = "GetItemsList";
        }

        public async Task Handle(ISession session, dynamic message)
        {
            await GetItemListTask.Execute(session, (string)message.RequestID);
        }

    }
}
