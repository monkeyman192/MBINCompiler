using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x844FED1B7CC7A30, NameHash = 0x424B3146F5B3FC26)]
    public class GcWarpAction : NMSTemplate
    {
		public enum WarpTypeEnum { BlackHole, SpacePOI }
		public WarpTypeEnum WarpType;
    }
}