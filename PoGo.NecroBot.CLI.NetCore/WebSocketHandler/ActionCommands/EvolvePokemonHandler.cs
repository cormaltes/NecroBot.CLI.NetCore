using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;

namespace PoGo.NecroBot.CLI.WebSocketHandler.ActionCommands
{
    public class EvolvePokemonHandler 
    {
        public string Command { get; private set;}

        public EvolvePokemonHandler()
        {
            Command = "EvolvePokemon";
        }

        public async Task Handle(ISession session, dynamic message)
        {
            await Logic.Tasks.EvolveSpecificPokemonTask.Execute(session, (ulong)message.PokemonId);
        }
    }
}