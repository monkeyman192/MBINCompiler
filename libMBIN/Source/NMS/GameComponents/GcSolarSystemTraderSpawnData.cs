using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        public int MaxToSpawn;
        public float InitialTakeoffDelay;
        public Vector2f SequenceTakeoffDelay;
        public int ChanceToDelayLaunch;
    }
}
