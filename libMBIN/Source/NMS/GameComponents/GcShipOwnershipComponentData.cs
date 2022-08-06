using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD04A4B8221B05F24, NameHash = 0xA947081E204C32BB)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        /* 0x0 */ public GcSpaceshipComponentData Data;
    }
}
