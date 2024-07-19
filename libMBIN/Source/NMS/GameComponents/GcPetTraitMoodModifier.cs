namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11C06A4BDDAD187C, NameHash = 0xD8A63B68)]
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
