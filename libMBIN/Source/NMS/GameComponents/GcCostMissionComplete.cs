using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x634808D2901CD16D, NameHash = 0x2AA270B1FED04EB4)]
    public class GcCostMissionComplete : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Cost;
        [NMS(Size = 0x20)]
        public string TextOverride;
        public bool HideIfCompleted;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
