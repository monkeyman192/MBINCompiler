namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48DCE697621A43CF, NameHash = 0x66A7186A5DDD202A)]
    public class GcPetEggSpeciesOverrideData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureID;
        [NMS(Index = 6)]
        /* 0x10 */ public float MaxScaleOverride;
        [NMS(Index = 5)]
        /* 0x14 */ public float MinScaleOverride;
        [NMS(Index = 2)]
        /* 0x18 */ public bool CanChangeAccessories;
        [NMS(Index = 3)]
        /* 0x19 */ public bool CanChangeColour;
        [NMS(Index = 1)]
        /* 0x1A */ public bool CanChangeGrowth;
        [NMS(Index = 4)]
        /* 0x1B */ public bool CanChangeTraits;
    }
}
