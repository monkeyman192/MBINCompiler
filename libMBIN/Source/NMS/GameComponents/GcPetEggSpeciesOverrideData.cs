namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B85B3F076600E6D, NameHash = 0x66A7186A5DDD202A)]
    public class GcPetEggSpeciesOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureID;
        /* 0x10 */ public float MaxScaleOverride;
        /* 0x14 */ public float MinScaleOverride;
        /* 0x18 */ public bool CanChangeAccessories;
        /* 0x19 */ public bool CanChangeColour;
        /* 0x1A */ public bool CanChangeGrowth;
        /* 0x1B */ public bool CanChangeTraits;
    }
}
