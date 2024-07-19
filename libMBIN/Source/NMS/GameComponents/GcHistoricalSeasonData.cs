using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF318DD4EC01B132, NameHash = 0xBDA618F)]
    public class GcHistoricalSeasonData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A SeasonName;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 8)]
        /* 0x40 */ public NMSString0x20A UnlockedTitle;
        [NMS(Index = 5)]
        /* 0x60 */ public TkTextureResource MainIcon;
        [NMS(Index = 7)]
        /* 0x78 */ public NMSString0x10 FinalReward;
        [NMS(Index = 4)]
        /* 0x88 */ public int DisplayNumber;
        [NMS(Index = 3)]
        /* 0x8C */ public int RemixNumber;
        [NMS(Index = 2)]
        /* 0x90 */ public int SeasonNumber;
        [NMS(Index = 6)]
        /* 0x94 */ public NMSString0x20 Description;
    }
}
