using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xB51027B0F5F84DDF, NameHash = 0x47A86F48A99F21F8)]
    public class GcAtlasRecvBaseQueryList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfBases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<GcPersistentBase> Bases;
    }
}
