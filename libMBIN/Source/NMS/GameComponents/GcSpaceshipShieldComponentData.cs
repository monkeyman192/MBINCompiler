namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F92ABACABD2E605, NameHash = 0x7A9767878AA5034)]
    public class GcSpaceshipShieldComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ShieldID;
        [NMS(Index = 2)]
        /* 0x10 */ public bool IgnoreHitsWhenPlayerAimingElsewhere;
        [NMS(Index = 1)]
        /* 0x11 */ public bool RotateOnHit;
    }
}
