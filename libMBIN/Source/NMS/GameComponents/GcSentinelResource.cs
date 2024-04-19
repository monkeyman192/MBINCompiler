namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FAE8CB924972158, NameHash = 0x68945B9C7D77B53)]
    public class GcSentinelResource : NMSTemplate
    {
        /* 0x00 */ public int BaseHealth;
        /* 0x04 */ public int HealthIncreasePerLevel;
        /* 0x08 */ public float RepairThreshold;
        /* 0x0C */ public float RepairTime;
        /* 0x10 */ public float Scale;
        /* 0x14 */ public NMSString0x80 Resource;
    }
}
