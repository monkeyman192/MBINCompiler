using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE4A96D14E7797E5, NameHash = 0x0DCD830657AF1993)]
    public class GcPetTraitStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetTraits Trait;
        /* 0x04 */ public float TraitMin;
        /* 0x04 */ public float TraitMax;
        /* 0x04 */ public float StaminaDrainModifierMin;
        /* 0x04 */ public float StaminaDrainModifierMax;
        /* 0x04 */ public float StaminaRechargeModifierMin;
        /* 0x04 */ public float StaminaRechargeModifierMax;
    }
}
