using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF2865BF1590FBBB3, NameHash = 0xF554DC208673EE3D)]
    public class GcBeenShotEvent : NMSTemplate
    {
		public enum ShotByEnum { Player, Anything, PlayerOrRemotePlayer }
		public ShotByEnum ShotBy;

        public int DamageThreshold;
        public float HealthThreshold;
    }
}