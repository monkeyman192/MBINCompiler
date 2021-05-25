using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x180, GUID = 0xD85DFF8ADAEB741D, NameHash = 0x9562AF9028346F05)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        /* 0x000 */ public bool IsEncrypted;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string TitleUpper;
        ///* 0x008 */ public NMSString0x20A TitleUpper;
        [NMS(Size = 0x20)]
        /* 0x028 */ public string Subtitle;
        ///* 0x028 */ public NMSString0x20A Subtitle;
        [NMS(Size = 0x20)]
        /* 0x048 */ public string Description;
        ///* 0x048 */ public NMSString0x20A Description;
        /* 0x068 */ public TkTextureResource Patch;
        /* 0x0EC */ public TkTextureResource HoverPopupIcon;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string DecryptMissionId;
    }
}
