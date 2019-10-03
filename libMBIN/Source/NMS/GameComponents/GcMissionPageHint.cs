using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAB554B2864B42A1D, NameHash = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
        // 0xB entries
		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, Catalogue, MissionLog, Discovery, Journey }
		public MissionPageHintEnum MissionPageHint;
    }
}
