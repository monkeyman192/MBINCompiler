using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x10E4E1659E2ABD9B, NameHash = 0x1A8AEEF0DF2E3D8A)]
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
		public enum SynchroniseScaleEnum { Never, Once, Always }
		public SynchroniseScaleEnum SynchroniseScale;
        public bool SupportTeleportation;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
