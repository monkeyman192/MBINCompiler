namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA0025A12F5C626D, NameHash = 0x38D56749327FCFE6)]
    public class GcAreaDamageData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 PlayerDamageId;
        /* 0x20 */ public float Damage;
        /* 0x24 */ public float DelayPerMetre;
        /* 0x28 */ public float Radius;
        /* 0x2C */ public bool DamageCreatures;
        /* 0x2D */ public bool DamagePlayers;
        /* 0x2E */ public bool InstantKill;
    }
}
