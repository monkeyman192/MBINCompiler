namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACFC6629DFF3384E, NameHash = 0xEC05D45E23EDDB7A)]
    public class GcPetTraitMoodModifier : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float MoodIncreaseMultiplierMax;
        [NMS(Index = 2)]
        /* 0x4 */ public float MoodIncreaseMultiplierMin;
        [NMS(Index = 1)]
        /* 0x8 */ public float TraitMax;
        [NMS(Index = 0)]
        /* 0xC */ public float TraitMin;
    }
}
