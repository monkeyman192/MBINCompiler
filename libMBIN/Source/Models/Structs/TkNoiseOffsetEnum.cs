namespace libMBIN.Models.Structs
{
    public class TkNoiseOffsetEnum : NMSTemplate
    {
		public enum OffsetTypeEnum { Zero, Base, All, SeaLevel }
		public OffsetTypeEnum OffsetType;
    }
}
