using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x66CAE7AA203660F7, NameHash = 0xE16B8EC5F09E6041)]
    public class GcVROverride_Layout : NMSTemplate
    {
        public enum VROverride_LayoutEnum { PosX, PosY, layerWidth, LayerHeight, MaxWidht }
        public VROverride_LayoutEnum VROverride_Layout;
        public float FloatValue;
    }
}
