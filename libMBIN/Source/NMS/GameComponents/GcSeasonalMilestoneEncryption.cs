using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x180, GUID = 0xD85DFF8ADAEB741D, NameHash = 0x9562AF9028346F05)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        /* 0x000 */ public bool IsEncrypted;
        /* 0x008 */ public NMSString0x20A TitleUpper;
        /* 0x028 */ public NMSString0x20A Subtitle;
        /* 0x048 */ public NMSString0x20A Description;
        /* 0x068 */ public TkTextureResource Patch;
        /* 0x0EC */ public TkTextureResource HoverPopupIcon;
        /* 0x170 */ public NMSString0x10 DecryptMissionId;
    }
}
