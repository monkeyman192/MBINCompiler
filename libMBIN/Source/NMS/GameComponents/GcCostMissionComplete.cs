using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x634808D2901CD16D, NameHash = 0x2AA270B1FED04EB4)]
    public class GcCostMissionComplete : NMSTemplate
    {
        public NMSString0x10 Cost;
        public NMSString0x20A TextOverride;
        public bool HideIfCompleted;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
