using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E04257E6113C422, NameHash = 0xEA1A333717C572C7)]
    public class GcBuildMenuIconSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Glow;
        [NMS(Index = 0)]
        /* 0x84 */ public TkTextureResource Normal;
    }
}
