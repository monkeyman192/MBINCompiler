using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5B112FF68130DF1, NameHash = 0x5EB6EE4B)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x28, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
