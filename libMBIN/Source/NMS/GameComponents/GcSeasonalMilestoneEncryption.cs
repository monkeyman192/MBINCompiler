using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70E3E9A857530E3D, NameHash = 0x9562AF9028346F05)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x20A Subtitle;
        [NMS(Index = 1)]
        /* 0x040 */ public NMSString0x20A TitleUpper;
        [NMS(Index = 6)]
        /* 0x060 */ public NMSString0x10 DecryptMissionId;
        [NMS(Index = 5)]
        /* 0x070 */ public TkTextureResource HoverPopupIcon;
        [NMS(Index = 4)]
        /* 0x0F4 */ public TkTextureResource Patch;
        [NMS(Index = 7)]
        /* 0x178 */ public int DecryptMissionSeed;
        [NMS(Index = 0)]
        /* 0x17C */ public bool IsEncrypted;
    }
}
