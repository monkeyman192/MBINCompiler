using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE69775A432B7DE63, NameHash = 0xDF5512FA05691ED2)]
    public class GcInteractionActivationCost : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> AltIds;
        [NMS(Index = 7)]
        /* 0x10 */ public List<int> OnlyChargeDuringSeasons;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 6)]
        /* 0x30 */ public NMSString0x10 StartMissionOnCantAfford;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 SubstanceId;
        [NMS(Index = 5)]
        /* 0x50 */ public NMSString0x10 UseCostID;
        [NMS(Index = 2)]
        /* 0x60 */ public int Cost;
        [NMS(Index = 3)]
        /* 0x64 */ public bool Repeat;
    }
}
