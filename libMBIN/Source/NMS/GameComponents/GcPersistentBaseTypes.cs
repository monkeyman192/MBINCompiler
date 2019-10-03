using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2B57F979912C5819, NameHash = 0x1E20A14918514C43)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // 0x7 entries
		public enum PersistentBaseTypesEnum { HomePlanetBase, FreighterBase, ExternalPlanetBase, CivilianFreighterBase, FriendsPlanetBase, FriendsFreighterBase, SpaceBase }
		public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
