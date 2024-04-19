using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD81D6F904454356D, NameHash = 0xC99C2140EB3A1A34)]
    public class GcItemFilterDataTableEntry : NMSTemplate
    {
        /* 0x00 */ public GcItemFilterData Filter;
        /* 0x50 */ public NMSString0x10 ID;
    }
}
