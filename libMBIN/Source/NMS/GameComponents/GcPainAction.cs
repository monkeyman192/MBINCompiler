namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BB641E9E7281432, NameHash = 0x9B8944FB55B77041)]
    public class GcPainAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Damage;
        /* 0x10 */ public float Radius;
        /* 0x14 */ public float RetriggerTime;
        /* 0x18 */ public bool AffectsPlayer;
        /* 0x19 */ public bool RadiusBasedDamage;
    }
}
