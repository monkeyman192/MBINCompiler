using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0xF9946461E0CCADDA, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        /* 0x12 */ public bool HideOptionAndDisplayCostOnly;
        /* 0x13 */ public bool RemoveOptionIfCantAfford;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public NMSTemplate Cost;
    }
}
