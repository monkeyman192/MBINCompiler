namespace libMBIN.Models.Structs
{
    public class GcBeenShotEvent : NMSTemplate
    {
		public enum ShotByEnum { Player, Anything }
		public ShotByEnum ShotBy;

        public int DamageThreshold;
        public float HealthThreshold;
    }
}
