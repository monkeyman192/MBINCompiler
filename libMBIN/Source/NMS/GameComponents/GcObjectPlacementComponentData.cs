using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        public NMSString0x20 GroupNodeName;

        public int ActivationType;
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding31;
    }
}
