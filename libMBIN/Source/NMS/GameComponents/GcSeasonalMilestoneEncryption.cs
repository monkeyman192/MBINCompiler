using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x668FCE5B1743986A, NameHash = 0x9562AF9028346F05)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Description;
        /* 0x020 */ public NMSString0x20A Subtitle;
        /* 0x040 */ public NMSString0x20A TitleUpper;
        /* 0x060 */ public NMSString0x10 DecryptMissionId;
        /* 0x070 */ public TkTextureResource HoverPopupIcon;
        /* 0x0F4 */ public TkTextureResource Patch;
        /* 0x178 */ public int DecryptMissionSeed;
        /* 0x17C */ public bool IsEncrypted;
    }
}
