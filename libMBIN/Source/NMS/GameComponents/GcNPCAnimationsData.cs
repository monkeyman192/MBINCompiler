using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5C0, GUID = 0xE5204A65B19E74E3, NameHash = 0x5344C3D579450D7B)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        public GcNPCAnimationSetData StandingAnimatons;
        public GcNPCAnimationSetData StandingIPadAnimatons;
        public GcNPCAnimationSetData SittingAnimatons;
        public GcNPCAnimationSetData SittingIPadAnimatons;
    }
}
