using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA8B4B99A33D23BF, NameHash = 0x886C03C3F3987F4)]
    public class GcAtlasDiscovery : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcAtlasMessage MessageData;
        [NMS(Index = 2)]
        /* 0x0B0 */ public GcAtlasDiscoveryData Data;
        [NMS(Index = 1)]
        /* 0x0F8 */ public GcDiscoveryOwner Owner;
        [NMS(Index = 0)]
        /* 0x1FC */ public GcAtlasDownloadType PackageType;
        [NMS(Index = 3)]
        /* 0x200 */ public GcAtlasDiscoveryMetadata Metadata;
        [NMS(Index = 5)]
        /* 0x280 */ public NMSString0x40 RID;
        [NMS(Index = 6)]
        /* 0x2C0 */ public NMSString0x20 PTK;
    }
}
