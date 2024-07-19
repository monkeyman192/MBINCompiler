using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99DF456F8036696D, NameHash = 0x8408F5C9)]
    public class GcBuildMenuIconSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Glow;
        [NMS(Index = 0)]
        /* 0x18 */ public TkTextureResource Normal;
    }
}
