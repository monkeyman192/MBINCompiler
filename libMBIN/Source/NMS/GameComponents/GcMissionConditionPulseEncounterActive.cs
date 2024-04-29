namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6519561B28425DF, NameHash = 0x56207A2C2009340)]
    public class GcMissionConditionPulseEncounterActive : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpecificObjectID;
        // size: 0x6
        public enum TestEncounterTypeEnum : uint {
            AnyEncounter,
            AnyObject,
            SpecificObject,
            Trader,
            AbandonedFreighter,
            AnyEncounterOtherThanTheNamedOne,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public TestEncounterTypeEnum TestEncounterType;
        [NMS(Index = 2)]
        /* 0x14 */ public bool RequireFullySpawned;
    }
}
