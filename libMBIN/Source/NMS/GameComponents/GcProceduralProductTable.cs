using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CDD42E4FF4A7917, NameHash = 0xB792767A)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1B, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x0 */ public GcProceduralProductData[] Table;
    }
}
