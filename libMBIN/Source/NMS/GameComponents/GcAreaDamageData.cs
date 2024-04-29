namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x795C4F9B2392C2AF, NameHash = 0x38D56749327FCFE6)]
    public class GcAreaDamageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 PlayerDamageId;
        [NMS(Index = 4)]
        /* 0x20 */ public float Damage;
        [NMS(Index = 2)]
        /* 0x24 */ public float DelayPerMetre;
        [NMS(Index = 1)]
        /* 0x28 */ public float Radius;
        [NMS(Index = 7)]
        /* 0x2C */ public bool DamageCreatures;
        [NMS(Index = 6)]
        /* 0x2D */ public bool DamagePlayers;
        [NMS(Index = 5)]
        /* 0x2E */ public bool InstantKill;
    }
}
