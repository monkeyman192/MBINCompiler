using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x2B57F979912C5819, NameHash = 0x1E20A14918514C43)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // size: 0x7
		public enum PersistentBaseTypesEnum { HomePlanetBase, FreighterBase, ExternalPlanetBase, CivilianFreighterBase, FriendsPlanetBase, FriendsFreighterBase, SpaceBase }
		public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}