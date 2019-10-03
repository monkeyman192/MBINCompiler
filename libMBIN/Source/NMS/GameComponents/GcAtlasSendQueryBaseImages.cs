using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x1FDF1BD7E4606BDA, NameHash = 0xA548038E5D04E6E0)]
    public class GcAtlasSendQueryBaseImages : NMSTemplate
    {
        /* 0x0 */ public ulong ClientUserdata;
        ///* 0x8 */ public List<Unknown> BaseQueries;
    }
}
