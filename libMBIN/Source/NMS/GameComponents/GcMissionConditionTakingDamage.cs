namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8FC632A9067DEA, NameHash = 0x1C7BDD4B8265FAA3)]
    public class GcMissionConditionTakingDamage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 DamageID;
        [NMS(Index = 0)]
        /* 0x10 */ public bool RequireShieldDown;
    }
}
