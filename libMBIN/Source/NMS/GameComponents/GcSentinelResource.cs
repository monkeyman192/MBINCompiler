namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBABBD124A383C47F, NameHash = 0x68945B9C7D77B53)]
    public class GcSentinelResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int BaseHealth;
        [NMS(Index = 2)]
        /* 0x04 */ public int HealthIncreasePerLevel;
        [NMS(Index = 4)]
        /* 0x08 */ public float RepairThreshold;
        [NMS(Index = 3)]
        /* 0x0C */ public float RepairTime;
        [NMS(Index = 5)]
        /* 0x10 */ public float Scale;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x80 Resource;
    }
}
