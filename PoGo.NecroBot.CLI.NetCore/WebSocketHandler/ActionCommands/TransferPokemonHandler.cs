using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler.ActionCommands
{
    public class TransferPokemonHandler 
    {
        public string Command { get; private set;}

        public TransferPokemonHandler()
        {
            Command = "TransferPokemon";
        }

        public async Task Handle(ISession session,  dynamic message)
        {
            await Logic.Tasks.TransferPokemonTask.Execute(session, (ulong)message.PokemonId);
        }
    }
}
