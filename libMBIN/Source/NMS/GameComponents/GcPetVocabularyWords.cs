namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA041098462C7EC70, NameHash = 0xDCBFB26222DD9DE6)]
    public class GcPetVocabularyWords : NMSTemplate
    {
        // size: 0xF
        public enum PetVocabularyWordEnum : uint {
            Attack,
            Dislike,
            Cute,
            Good,
            Happy,
            Hostile,
            Like,
            Lonely,
            Loved,
            Noise,
            OwnerLove,
            SummonedTrait,
            Hungry,
            Tickles,
            Yummy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetVocabularyWordEnum PetVocabularyWord;
    }
}
