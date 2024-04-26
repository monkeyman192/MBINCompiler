namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC92DB9B4AA0DC105, NameHash = 0x2581D5C5DE2A6E6)]
    public class GcCreaturePetMood : NMSTemplate
    {
        // size: 0x2
        public enum PetMoodEnum : uint {
            Hungry,
            Lonely,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetMoodEnum PetMood;
    }
}
