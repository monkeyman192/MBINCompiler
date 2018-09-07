using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x4)]
    public class GcMissionFaction : NMSTemplate
    {
		public enum MissionFactionEnum { Gek, Korvax, Vykeen, TradeGuild, WarriorGuild, ExplorerGuild, None }
		public MissionFactionEnum MissionFaction;
    }
}
