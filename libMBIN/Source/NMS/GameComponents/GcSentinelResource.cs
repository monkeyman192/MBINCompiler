namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9CAA30931E6D529, NameHash = 0x6A51E456)]
    public class GcSentinelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Resource;
        [NMS(Index = 1)]
        /* 0x10 */ public int BaseHealth;
        [NMS(Index = 2)]
        /* 0x14 */ public int HealthIncreasePerLevel;
        [NMS(Index = 4)]
        /* 0x18 */ public float RepairThreshold;
        [NMS(Index = 3)]
        /* 0x1C */ public float RepairTime;
        [NMS(Index = 5)]
        /* 0x20 */ public float Scale;
    }
}
