using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x8D81A5BDF05B8F09, NameHash = 0x88C56A28F5F9BFDA)]
    public class GcAtlasRecvFeaturedBasesQueryList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfBases;
        /* 0x18 */ public List<GcPersistentBase> Bases;
    }
}
