using BoardGameGeekAPI.BGGObjects;
using BoardGameGeekAPI.BGGObjects.Game;

namespace BoardGameGeekAPI
{
    public interface IBoardGameGeekConnector
    {
        Items GetUserCollection(
            string username, 
            bool rated = true, 
            bool stats = true, 
            bool own = true,
            int? wishListPriority = null);

        User GetUserInformation(string username, bool buddies = true);

        Game GetGame(int metadataGameId, bool stats = true);
    }
}