using System.Threading.Tasks;
using PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Events;
using PoGo.NecroBot.Logic.State;


namespace PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Tasks
{
    class GetPokemonSettingsTask
    {
    
        public static async Task Execute(ISession session, string requestID)
        {
            var settings = await session.Inventory.GetPokemonSettings();
            //webSocketSession.Send(EncodingHelper.Serialize(new WebResponce()
            //{
            //    Command = "PokemonSettings",
            //    Data = settings,
            //    RequestID = requestID
            //}));
        }

    }
}
