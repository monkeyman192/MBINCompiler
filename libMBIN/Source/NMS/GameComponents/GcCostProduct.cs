using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x8, GUID = 0xA3FCD9E831043706, NameHash = 0xE90BC34FB3DEA4D7)]
    public class GcCostProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1C */public byte[] EndPadding;
    }
}
