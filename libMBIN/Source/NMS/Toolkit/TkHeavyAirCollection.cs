using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDF7E1282F31CADFE, NameHash = 0x67009714D686CB9F)]
    public class TkHeavyAirCollection : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkHeavyAirData> HeavyAirSystems;
    }
}
