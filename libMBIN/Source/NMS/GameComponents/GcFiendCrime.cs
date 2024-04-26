namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F5426522A182A53, NameHash = 0xAF90A56B0E99C0CB)]
    public class GcFiendCrime : NMSTemplate
    {
        // size: 0x9
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FiendCrimeEnum FiendCrime;
    }
}
