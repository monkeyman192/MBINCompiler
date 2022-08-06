using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2869871E836C6B06, NameHash = 0xC8BCF436E2E840B6)]
    public class GcAtlasSendReport : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
		public enum PackageTypeEnum { Unknown, Discovery, Message }
        /* 0x10 */ public PackageTypeEnum PackageType;
        /* 0x14 */ public NMSString0x40 RID;
        /* 0x54 */ public GcUniverseAddressData UniverseAddress;
        /* 0x6C */ public NMSString0x20 RL;
        /* 0x8C */ public NMSString0x20 RC;
    }
}
