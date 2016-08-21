using System.Threading.Tasks;
using PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler.GetCommands
{
    public class GetPokemonListHandler : IWebSocketRequestHandler
    {
        public string Command { get; private set;}

        public GetPokemonListHandler()
        {
            Command = "GetPokemonList";
        }

        public async Task Handle(ISession session, dynamic message)
        {
            await GetPokemonListTask.Execute(session, (string)message.RequestID);
        }
    }
}
