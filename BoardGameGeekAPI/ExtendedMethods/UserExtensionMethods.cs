using System.Collections.Generic;
using System.Linq;
using BoardGameGeekAPI.BGGObjects;

namespace BoardGameGeekAPI.ExtendedMethods
{
    public static class UserExtensionMethods
    {
        public static IEnumerable<string> GetBuddies(this User user)
        {
            return user
                .buddies?
                .Where(buddies => buddies.buddy != null)
                .SelectMany(buddies => buddies?.buddy.Select(buddy => buddy.name)).ToArray();
        }
    }
}
