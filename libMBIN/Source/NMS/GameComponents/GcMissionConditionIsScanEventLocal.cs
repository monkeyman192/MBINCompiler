using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, Alignment = 0x8, GUID = 0x4E27A612337C1ECA, NameHash = 0x24A11989AE4D41A1)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        public NMSString0x20 Event;
        public bool RequiresFullFireteam;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
