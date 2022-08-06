using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x745FEF4C3098BB4B, NameHash = 0x056207A2C2009340)]
    public class GcMissionConditionPulseEncounterActive : NMSTemplate
    {
        // size: 0x6
        public enum TestEncounterTypeEnum { AnyEncounter, AnyObject, SpecificObject, Trader, AbandonedFreighter, AnyEncounterOtherThanTheNamedOne
        }
        /* 0x00 */ public TestEncounterTypeEnum TestEncounterType;
        /* 0x08 */ public NMSString0x10 SpecificObjectID;
        /* 0x18 */ public bool RequireFullySpawned;
    }
}
