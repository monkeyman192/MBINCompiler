using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xC2EECD23AFF2DBC4, NameHash = 0x1B95D5FDE04FECD9)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        /* 0x00 */ public bool HasFuel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        /* 0x08 */ public NMSString0x20 ActiveRecipe;
        /* 0x28 */ public int AmountToMake;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] EndPadding;
    }
}
