using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, Alignment = 0x4, GUID = 0x5C6F687D4A36F06B, NameHash = 0x1D300E2AA74F7BA7)]
    public class GcMissionFaction : NMSTemplate
    {
        // size: 0x8
		public enum MissionFactionEnum { Gek, Korvax, Vykeen, TradeGuild, WarriorGuild, ExplorerGuild, Nexus, None }
		public MissionFactionEnum MissionFaction;
    }
}