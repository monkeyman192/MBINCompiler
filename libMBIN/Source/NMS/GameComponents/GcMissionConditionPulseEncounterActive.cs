using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x70F769943A9DBEEB, NameHash = 0x056207A2C2009340)]
    public class GcMissionConditionPulseEncounterActive : NMSTemplate
    {
        public enum TestEncounterTypeEnum { AnyEncounter, AnyObject, SpecificObject, Trader, AbandonedFreighter };
        /* 0x00 */ public TestEncounterTypeEnum TestEncounterType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 SpecificObjectID;
        /* 0x18 */ public bool RequireFullySpawned;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}
