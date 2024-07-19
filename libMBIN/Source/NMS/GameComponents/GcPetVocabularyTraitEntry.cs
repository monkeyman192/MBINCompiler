using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E97ABFDB2AF60FB, NameHash = 0xB0C44BBF)]
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
