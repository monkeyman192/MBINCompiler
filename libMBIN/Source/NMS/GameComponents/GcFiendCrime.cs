namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x863BFCBD4C4DF7A6, NameHash = 0xE2E86D22)]
    public class GcFiendCrime : NMSTemplate
    {
        // size: 0xC
        public enum FiendCrimeEnum : uint {
            None,
            EggDamaged,
            EggDestroyed,
            EggCollected,
            UnderwaterPropDamaged,
            UnderwaterPropCollected,
            RockTransform,
            GroundPropDamage,
            ShotWorm,
            Carnage,
            FishCarnage,
            Bugs,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FiendCrimeEnum FiendCrime;
    }
}
