using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60EA1CB605AA45B9, NameHash = 0xF676D3AEF2BB991F)]
    public class GcAtlasBase : NMSTemplate
    {
        /* 0x000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x018 */ public NMSString0x200 OpaqueData;
        /* 0x218 */ public NMSString0x80 CustomName;
    }
}
