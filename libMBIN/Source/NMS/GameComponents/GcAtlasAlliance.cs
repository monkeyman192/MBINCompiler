using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E99EBCA7D9A043E, NameHash = 0xA6C8B6F5)]
    public class GcAtlasAlliance : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x000 */ public GcAtlasBanner Banner;
        [NMS(Index = 5)]
        /* 0x030 */ public ulong CreatedAt;
        [NMS(Index = 6)]
        /* 0x038 */ public ulong DeleteScheduledAt;
        [NMS(Index = 12)]
        /* 0x040 */ public GcAtlasAllianceStats Stats;
        [NMS(Index = 9)]
        /* 0x054 */ public int ActivityRank;
        [NMS(Index = 10)]
        /* 0x058 */ public int ActivityRankOutOf;
        [NMS(Index = 8)]
        /* 0x05C */ public float ActivityScore;
        [NMS(Index = 7)]
        /* 0x060 */ public int MemberCount;
        [NMS(Index = 0)]
        /* 0x064 */ public NMSString0x40 AllianceId;
        [NMS(Index = 4)]
        /* 0x0A4 */ public NMSString0x40 FounderHgUserId;
        [NMS(Index = 3)]
        /* 0x0E4 */ public NMSString0x20 HomeUa;
        [NMS(Index = 1)]
        /* 0x104 */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0x124 */ public NMSString0x20 Tag;
    }
}
