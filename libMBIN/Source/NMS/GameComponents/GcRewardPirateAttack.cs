namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F15B9CE19005CC8, NameHash = 0x76E8D6F5EA35F60C)]
    public class GcRewardPirateAttack : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 1)]
        /* 0x10 */ public int NumSquads;
        [NMS(Index = 0)]
        /* 0x14 */ public bool Instant;
    }
}
