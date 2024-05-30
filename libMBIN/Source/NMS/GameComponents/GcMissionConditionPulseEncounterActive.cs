namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE47E803C380F103C, NameHash = 0x56207A2C2009340)]
    public class GcMissionConditionPulseEncounterActive : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpecificObjectID;
        // size: 0x7
        public enum TestEncounterTypeEnum : uint {
            AnyEncounter,
            AnyObject,
            SpecificObject,
            Trader,
            AbandonedFreighter,
            AnyEncounterOtherThanTheNamedOne,
            SpecificID,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public TestEncounterTypeEnum TestEncounterType;
        [NMS(Index = 2)]
        /* 0x14 */ public bool RequireFullySpawned;
    }
}
