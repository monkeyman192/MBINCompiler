namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBC703E177D3D309, NameHash = 0xBEE7C907)]
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
