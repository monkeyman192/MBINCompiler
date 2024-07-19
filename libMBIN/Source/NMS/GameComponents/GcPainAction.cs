namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7535BE58B20247F0, NameHash = 0xF0A7F102)]
    public class GcPainAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Damage;
        [NMS(Index = 1)]
        /* 0x10 */ public float Radius;
        [NMS(Index = 4)]
        /* 0x14 */ public float RetriggerTime;
        [NMS(Index = 3)]
        /* 0x18 */ public bool AffectsPlayer;
        [NMS(Index = 2)]
        /* 0x19 */ public bool RadiusBasedDamage;
    }
}
