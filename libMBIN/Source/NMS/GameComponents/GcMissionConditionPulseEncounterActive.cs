namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F64ADF1F53718B9, NameHash = 0x9E849330)]
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
        [NMS(Index = 3)]
        /* 0x15 */ public bool ReturnFalseIfPulseDriveEngaged;
    }
}
