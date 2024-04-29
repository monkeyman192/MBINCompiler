using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23B60136062CA695, NameHash = 0x1E454D73CB415CEA)]
    public class GcAtlasBasesRequest : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 1)]
        /* 0x18 */ public GcGameMode GameMode;
        [NMS(Index = 3)]
        /* 0x1C */ public int MaxBytes;
        [NMS(Index = 2)]
        /* 0x20 */ public int MaxResults;
        [NMS(Index = 5)]
        /* 0x24 */ public int MaxVersion;
        [NMS(Index = 4)]
        /* 0x28 */ public int MinVersion;
        [NMS(Index = 6)]
        /* 0x2C */ public NMSString0x20 SpecificUserId;
    }
}
