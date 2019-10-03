using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCF2A9A7FC67347F, NameHash = 0xC42D0349854CDDDA)]
    public class GcMissionConditionMissionMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Message;
    }
}
