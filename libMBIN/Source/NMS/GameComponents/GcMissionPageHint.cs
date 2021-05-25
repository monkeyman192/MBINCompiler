using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xBAADE82FFF5952D4, NameHash = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
        // size: 0xB
		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, Catalogue, MissionLog, Discovery, Journey, Expedition }
		public MissionPageHintEnum MissionPageHint;
    }
}