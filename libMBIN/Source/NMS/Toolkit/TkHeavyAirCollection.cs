using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCCDF82FDDC184AF3, NameHash = 0x3DCFEF03)]
    public class TkHeavyAirCollection : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkHeavyAirData> HeavyAirSystems;
    }
}
