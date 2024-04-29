using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FE548A6019F0E3C, NameHash = 0xB9FD998A06AA6DE0)]
    public class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x00 */ public int[] MaxProductStackSizes;
        [NMS(Index = 2, Size = 0xD, EnumType = typeof(GcInventoryStackSizeGroup.InventoryStackSizeGroupEnum))]
        /* 0x34 */ public int[] MaxSubstanceStackSizes;
        [NMS(Index = 1)]
        /* 0x68 */ public int ProductStackLimit;
        [NMS(Index = 0)]
        /* 0x6C */ public int SubstanceStackLimit;
    }
}
