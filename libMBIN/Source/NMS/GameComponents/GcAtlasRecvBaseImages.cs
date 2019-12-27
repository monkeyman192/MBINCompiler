using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x7129073650A35082, NameHash = 0xC3C14D18029FA426)]
    public class GcAtlasRecvBaseImages : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfImages;
        /* 0x0C */ public int DataTimestamp;
        /* 0x10 */ public ulong ImageDataPtr;
        /* 0x18 */ public int ImageDataSize;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
