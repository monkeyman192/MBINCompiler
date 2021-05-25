using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xFEC2B020D496EB35, NameHash = 0xA548038E5D04E6E0)]
    public class GcAtlasSendQueryBaseImages : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public List<GcAtlasBaseQuery> BaseQueries;
    }
}
