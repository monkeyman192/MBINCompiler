namespace MBINCompiler.Models.Structs
{
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string GroupNodeName;

        public int ActivationType;
        /* 0x20 */ public string[] ActivationTypeValues()
        {
            return new[] { "GroupNode", "Locator"};
        }
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding31;
    }
}
