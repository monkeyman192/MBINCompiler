using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xB78074E3F1EFC33B, NameHash = 0x7454AD5214251C68)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
        public bool AllowPartiallyInstalled;
        public bool TeachIfNotKnown;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] EndPadding;
    }
}
