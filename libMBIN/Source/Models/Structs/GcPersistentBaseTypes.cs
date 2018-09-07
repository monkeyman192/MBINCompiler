using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPersistentBaseTypes : NMSTemplate
    {
		public enum PersistentBaseTypesEnum { HomePlanetBase, FreighterBase, ExternalPlanetBase, CivilianFreighterBase, FriendsPlanetBase, FriendsFreighterBase }
		public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
