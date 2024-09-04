using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB69D92CF6E0EF806, NameHash = 0x5EB6EE4B)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x29, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
