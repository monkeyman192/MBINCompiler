using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x8, GUID = 0x8BF18ADD8648960A, NameHash = 0x24A11989AE4D41A1)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
    }
}
