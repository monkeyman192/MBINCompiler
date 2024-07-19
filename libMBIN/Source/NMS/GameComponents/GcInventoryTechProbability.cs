namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x112E6E11E83935D1, NameHash = 0xFCCFB623)]
    public class GcInventoryTechProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Tech;
        // size: 0x4
        public enum DesiredTechProbabilityEnum : uint {
            Never,
            Rare,
            Common,
            Always,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public DesiredTechProbabilityEnum DesiredTechProbability;
    }
}
