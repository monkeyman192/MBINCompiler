using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBACB1CAC493CCF13, NameHash = 0x1E3880E5B9724A9C)]
    public class GcPlanetResourceIconLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x94 */ public TkTextureResource IconBinocs;
    }
}
