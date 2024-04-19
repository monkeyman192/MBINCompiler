using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEC0B12984C1344, NameHash = 0x270ED26636E9BF5B)]
    public class GcHistoricalSeasonData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A SeasonName;
        /* 0x020 */ public NMSString0x20A SeasonNameUpper;
        /* 0x040 */ public NMSString0x20A UnlockedTitle;
        /* 0x060 */ public NMSString0x10 FinalReward;
        /* 0x070 */ public TkTextureResource MainIcon;
        /* 0x0F4 */ public int DisplayNumber;
        /* 0x0F8 */ public int RemixNumber;
        /* 0x0FC */ public int SeasonNumber;
        /* 0x100 */ public NMSString0x20 Description;
    }
}
