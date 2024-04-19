using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x797C7234CC304289, NameHash = 0xDF5512FA05691ED2)]
    public class GcInteractionActivationCost : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AltIds;
        /* 0x10 */ public List<int> OnlyChargeDuringSeasons;
        /* 0x20 */ public NMSString0x10 RequiredTech;
        /* 0x30 */ public NMSString0x10 StartMissionOnCantAfford;
        /* 0x40 */ public NMSString0x10 SubstanceId;
        /* 0x50 */ public NMSString0x10 UseCostID;
        /* 0x60 */ public int Cost;
        /* 0x64 */ public bool Repeat;
    }
}
