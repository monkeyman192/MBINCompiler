namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x956A43E509D504AB, NameHash = 0xE2E86D22)]
    public class GcFiendCrime : NMSTemplate
    {
        // size: 0xD
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
            JellyBoss,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FiendCrimeEnum FiendCrime;
    }
}
