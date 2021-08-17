using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2F0, GUID = 0x28F613BC51BF1666, NameHash = 0x0886C03C3F3987F4)]
    public class GcAtlasDiscovery : NMSTemplate
    {
		public enum DownloadTypeEnum { Unknown, Discovery, Base, Message }
        /* 0x000 */ public DownloadTypeEnum DownloadType;
        /* 0x004 */ public GcDiscoveryOwner Owner;
        /* 0x108 */ public GcAtlasDiscoveryData Data;
        /* 0x150 */ public GcAtlasDiscoveryMetadata Metadata;
        /* 0x1D0 */ public GcAtlasMessage MessageData;
        /* 0x290 */ public NMSString0x40 RID;
        /* 0x2D0 */ public NMSString0x20 PTK;
    }
}
