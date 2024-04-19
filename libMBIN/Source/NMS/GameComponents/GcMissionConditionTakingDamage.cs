namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F266D6E329972D6, NameHash = 0x1C7BDD4B8265FAA3)]
    public class GcMissionConditionTakingDamage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageID;
        /* 0x10 */ public bool RequireShieldDown;
    }
}
