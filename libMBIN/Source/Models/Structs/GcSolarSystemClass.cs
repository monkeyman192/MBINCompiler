namespace libMBIN.Models.Structs
{
    public class GcSolarSystemClass : NMSTemplate
    {
		public enum SolarSystemClassEnum { Default, Initial, Anomaly, GameStart }
		public SolarSystemClassEnum SolarSystemClass;
    }
}
