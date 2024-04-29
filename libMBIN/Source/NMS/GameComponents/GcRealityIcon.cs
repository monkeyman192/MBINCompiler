using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE2A87D2901D6A82, NameHash = 0x28AB5E6C29FCA8E5)]
    public class GcRealityIcon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 1)]
        /* 0x20 */ public TkTextureResource Texture;
    }
}
