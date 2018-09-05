using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPersistentBaseTypes : NMSTemplate
    {
        public int PersistentBaseTypes;
        public string[] PersistentBaseTypesValues()
        {
            return new[] { "HomePlanetBase", "FreighterBase", "ExternalPlanetBase", "CivilianFreighterBase", "FriendsPlanetBase", "FriendsFreighterBase" };
        }
    }
}
