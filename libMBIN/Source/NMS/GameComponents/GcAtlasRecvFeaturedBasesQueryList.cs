using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xC51628B104A72A46, NameHash = 0x88C56A28F5F9BFDA)]
    public class GcAtlasRecvFeaturedBasesQueryList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfBases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<GcPersistentBase> Bases;
    }
}
