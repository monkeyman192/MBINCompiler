using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3F4D5B6E4AA809A, NameHash = 0xB792767A)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1A, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x0 */ public GcProceduralProductData[] Table;
    }
}
