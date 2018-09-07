namespace libMBIN.Models.Structs
{
    public class GcPlanetSentinelData : NMSTemplate
    {
		public enum SentinelLevelEnum { Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}
