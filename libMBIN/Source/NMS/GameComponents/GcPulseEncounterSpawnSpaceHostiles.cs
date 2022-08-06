using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4196C86B688428, NameHash = 0x0203F104657EA616)]
    public class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public int NumberOfShips;
        /* 0x2B0 */ public NMSString0x10 AttackDefinition;
    }
}
