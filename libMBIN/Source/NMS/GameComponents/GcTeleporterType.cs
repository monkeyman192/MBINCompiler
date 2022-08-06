using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94984A317842AEE5, NameHash = 0xECE6F42F8A522B34)]
    public class GcTeleporterType : NMSTemplate
    {
        // size: 0xA
        public enum TeleporterDestinationTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix,
            OnNexus, SpacestationFixPosition, Settlement, Freighter
        }
        /* 0x0 */ public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
