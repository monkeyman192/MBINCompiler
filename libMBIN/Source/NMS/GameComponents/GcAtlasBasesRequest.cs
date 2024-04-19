using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93B2FDEC3B2BFFDA, NameHash = 0x1E454D73CB415CEA)]
    public class GcAtlasBasesRequest : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public GcGameMode GameMode;
        /* 0x1C */ public int MaxBytes;
        /* 0x20 */ public int MaxResults;
        /* 0x24 */ public int MaxVersion;
        /* 0x28 */ public int MinVersion;
        /* 0x2C */ public NMSString0x20 SpecificUserId;
    }
}
