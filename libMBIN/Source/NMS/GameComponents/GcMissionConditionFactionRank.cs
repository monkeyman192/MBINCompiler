using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF910A8B31E349874, NameHash = 0x986E86EA3EB2C57C)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        /* 0x0 */ public GcMissionFaction Faction;
        /* 0x4 */ public bool UseSystemRace;
        /* 0x8 */ public int Rank;
    }
}
