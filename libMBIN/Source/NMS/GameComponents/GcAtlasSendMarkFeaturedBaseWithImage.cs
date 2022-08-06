using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43B957129D1B95F6, NameHash = 0x4845AFA2BB576F24)]
    public class GcAtlasSendMarkFeaturedBaseWithImage : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public NMSString0x40 BaseID;
        /* 0x50 */ public List<byte> Image;  // Just a dummy type. This will be the actual image data.
    }
}
