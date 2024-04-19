using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF83BC00DCA9A3E83, NameHash = 0xE41D8EA9BE5AA4F8)]
    public class GcPetBehaviourTraitModifier : NMSTemplate
    {
        /* 0x00 */ public float CooldownModifierMax;
        /* 0x04 */ public float CooldownModifierMin;
        /* 0x08 */ public GcCreaturePetTraits Trait;
        /* 0x0C */ public float TraitMax;
        /* 0x10 */ public float TraitMin;
        /* 0x14 */ public float WeightModifierMax;
        /* 0x18 */ public float WeightModifierMin;
    }
}
