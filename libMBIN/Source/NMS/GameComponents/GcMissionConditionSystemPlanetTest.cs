using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1, Alignment = 0x1, GUID = 0xFB24FC538BB5DD91, NameHash = 0xB22694B55382153C)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        public bool RequiresExtremePlanet;
    }
}
