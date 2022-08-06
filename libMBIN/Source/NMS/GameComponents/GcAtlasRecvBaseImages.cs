using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86590CF5159C1D17, NameHash = 0xC3C14D18029FA426)]
    public class GcAtlasRecvBaseImages : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfImages;
        /* 0x14 */ public int DataTimestamp;
        /* 0x18 */ public ulong ImageDataPtr;
        /* 0x20 */ public int ImageDataSize;
    }
}
