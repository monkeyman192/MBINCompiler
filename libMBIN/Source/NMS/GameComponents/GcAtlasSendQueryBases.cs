using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xAF856923011219F1, NameHash = 0x993780B561119F0D)]
    public class GcAtlasSendQueryBases : NMSTemplate
    {
        /* 0x0 */ public ulong ClientUserdata;
        ///* 0x8 */ public List<Unknown> BaseQueries;
    }
}
