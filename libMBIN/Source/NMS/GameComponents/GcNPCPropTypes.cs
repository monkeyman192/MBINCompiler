using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB910AB8E8A65A4F1, NameHash = 0xC6B93CF490CDB3AC)]
    public class GcNPCPropTypes : NMSTemplate
    {
        // size: 0xD
        public enum NPCPropEnum { None, IPad, HoloBlob, HoloFrigate, HoloShip, HoloMultitool, HoloSolarSystem,
            Container, Box, Cup, DontCare, RandomHologram, HoloDrone
        }
        /* 0x0 */ public NPCPropEnum NPCProp;
    }
}
