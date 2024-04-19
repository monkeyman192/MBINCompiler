using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11259BB40F6BA697, NameHash = 0xE14D5B0B53D91D7C)]
    public class GcPetEggTraitModifierOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public NMSString0x10 SubstanceID;
        /* 0x20 */ public int BaseValueOverride;
        /* 0x24 */ public GcCreaturePetTraits Trait;
        /* 0x28 */ public bool IncreasesTrait;
    }
}
