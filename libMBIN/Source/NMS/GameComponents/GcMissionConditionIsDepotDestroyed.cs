using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x4A042E3F380B4B0E, NameHash = 0x2797515E3A43C26C)]
    public class GcMissionConditionIsDepotDestroyed : NMSTemplate
    {
        public NMSString0x20 ControllingScanEvent;
    }
}
