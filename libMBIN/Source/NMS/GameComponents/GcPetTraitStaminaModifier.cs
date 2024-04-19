using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5672F857EC49B2E6, NameHash = 0xDCD830657AF1993)]
    public class GcPetTraitStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public float StaminaDrainModifierMax;
        /* 0x04 */ public float StaminaDrainModifierMin;
        /* 0x08 */ public float StaminaRechargeModifierMax;
        /* 0x0C */ public float StaminaRechargeModifierMin;
        /* 0x10 */ public GcCreaturePetTraits Trait;
        /* 0x14 */ public float TraitMax;
        /* 0x18 */ public float TraitMin;
    }
}
