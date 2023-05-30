using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        public NMSString0x10 EffectName;

        public float Scale;
        public float MinCreatureSize;
        public float MaxCreatureSize;
        public int MoveSpeed;
        public string[] MoveSpeedValues()
        {
            return new[] { "Always", "Walk", "Run" };
        }
    }
}
