using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6DB5B1675593208, NameHash = 0xA03E661BB27C6E6A)]
    public class GcPetFollowUpBehaviour : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcPetBehaviours Behaviour;
        [NMS(Index = 2)]
        /* 0x04 */ public GcCreaturePetTraits Trait;
        [NMS(Index = 4)]
        /* 0x08 */ public float TraitMax;
        [NMS(Index = 3)]
        /* 0x0C */ public float TraitMin;
        [NMS(Index = 6)]
        /* 0x10 */ public float WeightMax;
        [NMS(Index = 5)]
        /* 0x14 */ public float WeightMin;
        [NMS(Index = 1)]
        /* 0x18 */ public bool TraitBased;
    }
}
