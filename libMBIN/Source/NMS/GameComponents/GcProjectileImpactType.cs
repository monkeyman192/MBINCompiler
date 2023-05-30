namespace libMBIN.NMS.GameComponents
{
    public class GcProjectileImpactType : NMSTemplate
    {
        public enum ImpactEnum : uint {
            Default,
            Terrain,
            Substance,
            Rock,
            Asteroid,
            Shield,
            Creature,
            Robot,
            Freighter,
            Cargo,
            Ship,
            Plant,
        }
        public ImpactEnum Impact;
    }
}
