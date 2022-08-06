using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x634808D2901CD16D, NameHash = 0x2AA270B1FED04EB4)]
    public class GcCostMissionComplete : NMSTemplate
    {
        public NMSString0x10 Cost;
        public NMSString0x20A TextOverride;
        public bool HideIfCompleted;
    }
}
