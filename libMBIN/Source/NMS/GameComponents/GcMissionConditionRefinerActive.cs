using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC2EECD23AFF2DBC4, NameHash = 0x1B95D5FDE04FECD9)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        /* 0x00 */ public bool HasFuel;
        /* 0x08 */ public NMSString0x20A ActiveRecipe;
        /* 0x28 */ public int AmountToMake;
    }
}
