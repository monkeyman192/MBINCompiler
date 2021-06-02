using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0x3D75143BE008F7FF, NameHash = 0x6520972F5B89CD77)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 GroupNodeName;

		public enum ActivationTypeEnum { GroupNode, Locator }
		public ActivationTypeEnum ActivationType;
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;
        public bool UseNodeParent;

        [NMS(Size = 2, Ignore = true)]
        public byte[] EndPadding;
    }
}
