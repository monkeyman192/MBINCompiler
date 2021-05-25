using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x6DCC4E8DC485D130, NameHash = 0xDCBFB26222DD9DE6)]
    public class GcPetVocabularyWords : NMSTemplate
    {
        // size: 0xF
        public enum PetVocabularyWordEnum {
            Attack, Dislike, Cute, Good, Happy, Hostile, Like, Lonely, Loved, Noise,
            OwnerLove, SummonedTrait, Hungry, Tickles, Yummy
        }
        public PetVocabularyWordEnum PetVocabularyWord;
    }
}
