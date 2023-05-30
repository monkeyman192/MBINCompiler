using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcShootableComponentData : NMSTemplate
    {
        public int Health;
        public bool AutoAimTarget;
        public bool PlayerOnly;
        public bool ImpactShake;
        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding7;
        public NMSString0x10 ImpactShakeEffect;

        public GcProjectileImpactType ImpactType;
        public int IncreaseWanted;
        public float IncreaseWantedThresholdTime;
        public bool UseMiningDamage;
        public int MinDamage;
        public bool StaticUntilShot;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding2D;
    }
}
