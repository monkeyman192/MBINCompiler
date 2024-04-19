using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A1F612CFFA8437F, NameHash = 0x886C03C3F3987F4)]
    public class GcAtlasDiscovery : NMSTemplate
    {
        /* 0x000 */ public GcAtlasMessage MessageData;
        /* 0x0B0 */ public GcAtlasDiscoveryData Data;
        /* 0x0F8 */ public GcDiscoveryOwner Owner;
        /* 0x1FC */ public GcAtlasDownloadType PackageType;
        /* 0x200 */ public GcAtlasDiscoveryMetadata Metadata;
        /* 0x280 */ public NMSString0x40 RID;
        /* 0x2C0 */ public NMSString0x20 PTK;
    }
}
