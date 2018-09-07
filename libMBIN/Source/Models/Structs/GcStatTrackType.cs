namespace libMBIN.Models.Structs
{
    public class GcStatTrackType : NMSTemplate
    {
		public enum StatTrackTypeEnum { Set, Add, Max, Min }
		public StatTrackTypeEnum StatTrackType;
    }
}
