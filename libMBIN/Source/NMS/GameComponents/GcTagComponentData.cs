using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8CF512736318FA2, NameHash = 0xBA9A777F)]
    public class GcTagComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcStaticTag StaticTags;
    }
}
