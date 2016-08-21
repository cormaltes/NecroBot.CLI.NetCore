using System.Threading.Tasks;
using PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler.GetCommands
{
    class GetEggListHandler 
    {
        public string Command { get; private set; }

        public GetEggListHandler()
        {
            Command = "GetEggList";
        }

        public async Task Handle(ISession session, dynamic message)
        {
            await GetEggListTask.Execute(session, (string)message.RequestID);
        }
    }
}
