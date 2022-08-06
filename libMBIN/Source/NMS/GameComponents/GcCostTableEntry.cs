using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC87CADD1BFD6AA5, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        /* 0x12 */ public bool HideOptionAndDisplayCostOnly;
        /* 0x13 */ public bool DisplayOnlyCostIfCantAfford;
        /* 0x14 */ public bool HideCostStringIfCanAfford;
        /* 0x15 */ public bool RemoveOptionIfCantAfford;
        /* 0x16 */ public bool MustAffordInCreative;
        /* 0x18 */ public NMSString0x20A CannotAffordOSDMsg;
        /* 0x38 */ public NMSString0x10 MissionMessageWhenCharged;
        /* 0x48 */ public NMSTemplate Cost;
    }
}
