using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC229525A6A8F7B75, NameHash = 0xE14D5B0B53D91D7C)]
    public class GcPetEggTraitModifierOverrideData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 SubstanceID;
        [NMS(Index = 4)]
        /* 0x20 */ public int BaseValueOverride;
        [NMS(Index = 2)]
        /* 0x24 */ public GcCreaturePetTraits Trait;
        [NMS(Index = 3)]
        /* 0x28 */ public bool IncreasesTrait;
    }
}
