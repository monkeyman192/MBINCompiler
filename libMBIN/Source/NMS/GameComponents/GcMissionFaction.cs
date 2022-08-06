using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85ADDC0425D7E569, NameHash = 0x1D300E2AA74F7BA7)]
    public class GcMissionFaction : NMSTemplate
    {
        // size: 0x9
        public enum MissionFactionEnum { Gek, Korvax, Vykeen, TradeGuild, WarriorGuild, ExplorerGuild, Nexus, Pirates,
            None
        }
        /* 0x0 */ public MissionFactionEnum MissionFaction;
    }
}
