using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x500ED63F2A218433, NameHash = 0x270ED26636E9BF5B)]
    public class GcHistoricalSeasonData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A SeasonName;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 8)]
        /* 0x040 */ public NMSString0x20A UnlockedTitle;
        [NMS(Index = 7)]
        /* 0x060 */ public NMSString0x10 FinalReward;
        [NMS(Index = 5)]
        /* 0x070 */ public TkTextureResource MainIcon;
        [NMS(Index = 4)]
        /* 0x0F4 */ public int DisplayNumber;
        [NMS(Index = 3)]
        /* 0x0F8 */ public int RemixNumber;
        [NMS(Index = 2)]
        /* 0x0FC */ public int SeasonNumber;
        [NMS(Index = 6)]
        /* 0x100 */ public NMSString0x20 Description;
    }
}
