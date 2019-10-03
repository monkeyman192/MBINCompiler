using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x50110D545A0595, NameHash = 0x7454AD5214251C68)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
        public bool AllowPartiallyInstalled;
        public bool TeachIfNotKnown;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] EndPadding;
    }
}
