using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1A248F0F98435D2F, NameHash = 0xA75A686CCD91261E)]
    public class GcMissionGalacticPoint : NMSTemplate      // size: 0x4
    {
		public enum GalacticPointEnum { Atlas, BlackHole }
		public GalacticPointEnum GalacticPoint;
    }
}
