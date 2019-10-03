using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB3FD0C5AC8F65C2E, NameHash = 0x424B3146F5B3FC26)]
    public class GcWarpAction : NMSTemplate
    {
		public enum WarpTypeEnum { BlackHole }
		public WarpTypeEnum WarpType;
    }
}
