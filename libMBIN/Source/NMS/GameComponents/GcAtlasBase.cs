using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBDA6E267DF083E1, NameHash = 0xF676D3AEF2BB991F)]
    public class GcAtlasBase : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 0)]
        /* 0x018 */ public NMSString0x200 OpaqueData;
        [NMS(Index = 2)]
        /* 0x218 */ public NMSString0x80 CustomName;
    }
}
