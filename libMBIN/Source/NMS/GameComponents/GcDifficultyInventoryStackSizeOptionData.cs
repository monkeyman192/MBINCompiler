using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FE5960472FA8854, NameHash = 0xB9FD998A06AA6DE0)]
    public class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
    {
        [NMS(Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x00 */ public int[] MaxProductStackSizes;
        [NMS(Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x34 */ public int[] MaxSubstanceStackSizes;
        /* 0x68 */ public int ProductStackLimit;
        /* 0x6C */ public int SubstanceStackLimit;
    }
}
