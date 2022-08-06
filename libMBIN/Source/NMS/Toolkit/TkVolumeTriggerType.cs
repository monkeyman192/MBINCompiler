using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB31ADC3F23E932F1, NameHash = 0xA4F2D5595864317D)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x12
        public enum VolumeTriggerTypeEnum { Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom,
            OpenCovered, HazardProtection, FieldBoundary, Custom_Biodome, Portal,
            VehicleBoost, NexusPlaza, NexusCommunityHub, NexusHangar, RaceObstacle,
            HazardProtectionCold, SpaceStorm
        }
        /* 0x0 */ public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
