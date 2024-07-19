using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17CF5BC54D8D5EDB, NameHash = 0xC4A3E973)]
    public class GcRealityIcon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 1)]
        /* 0x20 */ public TkTextureResource Texture;
    }
}
