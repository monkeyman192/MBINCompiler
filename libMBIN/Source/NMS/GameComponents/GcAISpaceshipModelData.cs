using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x68081EC8A0CFF6B9, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
        public GcFrigateClass FrigateClass;
    }
}
