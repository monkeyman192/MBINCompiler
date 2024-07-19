namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x158E51018B850276, NameHash = 0xB5B8F939)]
    public class GcCreaturePetTraits : NMSTemplate
    {
        // size: 0x3
        public enum PetTraitEnum : uint {
            Helpfulness,
            Aggression,
            Independence,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetTraitEnum PetTrait;
    }
}
