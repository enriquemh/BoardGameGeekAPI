using System.Linq;
using BoardGameGeekAPI.BGGObjects;

namespace BoardGameGeekAPI.ExtendedMethods
{
    public static class ItemsExtensionMethods
    {
        public static string GetName(this itemsItem itemsItem)
        {
            return itemsItem.name.FirstOrDefault()?.Value;
        }
    }
}
