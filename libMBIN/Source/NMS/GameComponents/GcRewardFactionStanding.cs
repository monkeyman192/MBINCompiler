using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30D10F162855BDDA, NameHash = 0x8B79DF642602985A)]
    public class GcRewardFactionStanding : NMSTemplate
    {
        /* 0x0 */ public GcMissionFaction Faction;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public int AmountMax;
        /* 0xC */ public bool SetToMinBeforeAdd;
    }
}
