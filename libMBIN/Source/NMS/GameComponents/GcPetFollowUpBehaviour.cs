using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9E238B0102214C, NameHash = 0xA03E661BB27C6E6A)]
    public class GcPetFollowUpBehaviour : NMSTemplate
    {
        /* 0x00 */ public GcPetBehaviours Behaviour;
        /* 0x04 */ public GcCreaturePetTraits Trait;
        /* 0x08 */ public float TraitMax;
        /* 0x0C */ public float TraitMin;
        /* 0x10 */ public float WeightMax;
        /* 0x14 */ public float WeightMin;
        /* 0x18 */ public bool TraitBased;
    }
}
