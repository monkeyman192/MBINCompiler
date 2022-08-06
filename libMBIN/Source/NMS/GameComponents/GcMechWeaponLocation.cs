using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD13E5E200C9ADC04, NameHash = 0x87D2DB7CF99E11A4)]
    public class GcMechWeaponLocation : NMSTemplate
    {
        // size: 0x4
        public enum MechWeaponLocationEnum { TurretExocraft, TurretSentinel, ArmLeft, ArmRight }
        /* 0x0 */ public MechWeaponLocationEnum MechWeaponLocation;
    }
}
