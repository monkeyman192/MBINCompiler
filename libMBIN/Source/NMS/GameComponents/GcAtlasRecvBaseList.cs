using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x29046730D3CB288A, NameHash = 0xA756A03382448724)]
    public class GcAtlasRecvBaseList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfBases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<GcPersistentBase> Bases;
        /* 0x20 */ public List<GcPersistentTerrainEdits> BaseTerrainEdits;
    }
}
