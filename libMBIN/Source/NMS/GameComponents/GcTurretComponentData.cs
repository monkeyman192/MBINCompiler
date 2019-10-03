using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xAEC2575916A4ACFE, NameHash = 0x88530A815E5B1B46)]
    public class GcTurretComponentData : NMSTemplate
    {
		public enum GunTypeEnum { Laser, Projectile, Missile }
		public GunTypeEnum GunType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string LaserEffectId;
        [NMS(Size = 0x10)]
        public string LaserMuzzleFlashId;
        [NMS(Size = 0x10)]
        public string ProjectileId;
        [NMS(Size = 0x10)]
        public string ProjectileMuzzleFlashId;
        [NMS(Size = 0x10)]
        public string MissileId;
    }
}
