using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE336A341E0231EDD, NameHash = 0x1F2D7A4D)]
    public class TkEntitlementList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkEntitlementListData> Entitlements;
    }
}
