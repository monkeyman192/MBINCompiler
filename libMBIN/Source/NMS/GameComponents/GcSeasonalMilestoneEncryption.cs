using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8252843446DD7B7E, NameHash = 0x87AA2A7F)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A Subtitle;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A TitleUpper;
        [NMS(Index = 5)]
        /* 0x60 */ public TkTextureResource HoverPopupIcon;
        [NMS(Index = 4)]
        /* 0x78 */ public TkTextureResource Patch;
        [NMS(Index = 6)]
        /* 0x90 */ public NMSString0x10 DecryptMissionId;
        [NMS(Index = 7)]
        /* 0xA0 */ public int DecryptMissionSeed;
        [NMS(Index = 0)]
        /* 0xA4 */ public bool IsEncrypted;
    }
}
