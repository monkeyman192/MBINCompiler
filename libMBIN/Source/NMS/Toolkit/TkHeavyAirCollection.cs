using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x74C5AC5E4E45D2A3, NameHash = 0x67009714D686CB9F)]
    public class TkHeavyAirCollection : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkHeavyAirData> HeavyAirSystems;
    }
}
