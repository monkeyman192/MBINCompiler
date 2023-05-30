using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerDamageData : NMSTemplate
    {
        public NMSString0x10 Id;
        public NMSString0x20 DeathMessage;
        public TkTextureResource HitIcon;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
        public NMSString0x20 HitMessage;
        public NMSString0x20 CriticalHitMessage;
        public float Damage;
        public float PushForce;
        public float CameraTurn;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding104;
        public NMSString0x10 CameraShakeShield;
        public NMSString0x10 CameraShakeNoShield;
    }
}
