using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x23D1A40BAFED32A4, NameHash = 0xF554DC208673EE3D)]
    public class GcBeenShotEvent : NMSTemplate
    {
		public enum ShotByEnum { Player, Anything }
		public ShotByEnum ShotBy;

        public int DamageThreshold;
        public float HealthThreshold;
    }
}
