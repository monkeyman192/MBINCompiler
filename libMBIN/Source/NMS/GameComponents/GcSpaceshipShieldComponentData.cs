namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F92ABACABD2E605, NameHash = 0x7A9767878AA5034)]
    public class GcSpaceshipShieldComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ShieldID;
        /* 0x10 */ public bool IgnoreHitsWhenPlayerAimingElsewhere;
        /* 0x11 */ public bool RotateOnHit;
    }
}
