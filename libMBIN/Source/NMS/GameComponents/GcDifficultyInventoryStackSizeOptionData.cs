using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FE548A6019F0E3C, NameHash = 0xAC316DD4)]
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
