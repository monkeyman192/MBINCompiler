namespace libMBIN.Models.Structs
{
    public class GcStatType : NMSTemplate // not the same as GcStatsTypes
    {
		public enum StatTypeEnum { Int, Float, AvgRate }
		public StatTypeEnum StatType;
    }
}
