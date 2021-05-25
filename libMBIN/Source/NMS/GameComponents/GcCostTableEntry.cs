using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, Alignment = 0x8, GUID = 0xC1902D5884D707C2, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        /* 0x12 */ public bool HideOptionAndDisplayCostOnly;
        /* 0x13 */ public bool DisplayOnlyCostIfCantAfford;
        /* 0x14 */ public bool RemoveOptionIfCantAfford;
        /* 0x15 */ public bool MustAffordInCreative;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x16 */ public byte[] Padding16;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string CannotAffordOSDMsg;
        ///* 0x18 */ public NMSString0x20A CannotAffordOSDMsg;
        /* 0x38 */ public NMSTemplate Cost;
    }
}
