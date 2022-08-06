using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9EC9F5558C421D7D, NameHash = 0x67009714D686CB9F)]
    public class TkHeavyAirCollection : NMSTemplate
    {
        public List<TkHeavyAirData> HeavyAirSystems;
    }
}
