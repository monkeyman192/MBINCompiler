using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1371942C474D2758, NameHash = 0xCCBEF4F753544A3F)]
    public class GcStatTrackType : NMSTemplate
    {
		public enum StatTrackTypeEnum { Set, Add, Max, Min }
		public StatTrackTypeEnum StatTrackType;
    }
}