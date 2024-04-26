using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA055504BF90A3AA6, NameHash = 0xD1AA1B644B5DE736)]
    public class GcPetVocabularyTraitEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Negative;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Positive;
        [NMS(Index = 0)]
        /* 0x40 */ public GcCreaturePetTraits Trait;
    }
}
