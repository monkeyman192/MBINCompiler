using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F62A7C36CBE05BD, NameHash = 0xDCD830657AF1993)]
    public class GcPetTraitStaminaModifier : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float StaminaDrainModifierMax;
        [NMS(Index = 3)]
        /* 0x04 */ public float StaminaDrainModifierMin;
        [NMS(Index = 6)]
        /* 0x08 */ public float StaminaRechargeModifierMax;
        [NMS(Index = 5)]
        /* 0x0C */ public float StaminaRechargeModifierMin;
        [NMS(Index = 0)]
        /* 0x10 */ public GcCreaturePetTraits Trait;
        [NMS(Index = 2)]
        /* 0x14 */ public float TraitMax;
        [NMS(Index = 1)]
        /* 0x18 */ public float TraitMin;
    }
}
