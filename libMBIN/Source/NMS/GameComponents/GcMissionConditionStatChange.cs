using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x8BFCD316778640C0, NameHash = 0x9481201C43F8E7A3)]
    public class GcMissionConditionStatChange : NMSTemplate
    {
        public NMSString0x10 Stat;
        public NMSString0x10 StatGroup;
    }
}
