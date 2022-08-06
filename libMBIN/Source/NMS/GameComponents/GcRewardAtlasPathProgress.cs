using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x40F3E6BA599AC188, NameHash = 0x2FFD5C572426F075)]
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
		public enum AtlasPathProgressTypeEnum { IncrementPathProgress, FinalStoryAtlas }
		public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}