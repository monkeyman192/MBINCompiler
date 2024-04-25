using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x436FB21FC7E1E24C, NameHash = 0x6DD030A653A9BBF2)]
    public class TkEntitlementList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkEntitlementListData> Entitlements;
    }
}
