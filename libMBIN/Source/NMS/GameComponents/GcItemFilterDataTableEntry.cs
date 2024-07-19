using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6419511760B1BE1, NameHash = 0x54C2A0CD)]
    public class GcItemFilterDataTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcItemFilterData Filter;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ID;
    }
}
