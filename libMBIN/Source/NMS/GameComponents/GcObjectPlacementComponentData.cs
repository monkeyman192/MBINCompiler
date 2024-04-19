namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44119D1A01247A34, NameHash = 0x6520972F5B89CD77)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        // size: 0x2
        public enum ActivationTypeEnum : uint {
            GroupNode,
            Locator,
        }
        /* 0x00 */ public ActivationTypeEnum ActivationType;
        /* 0x04 */ public float FractionOfNodesActive;
        /* 0x08 */ public int MaxGroupsActivated;
        /* 0x0C */ public int MaxNodesActivated;
        /* 0x10 */ public NMSString0x20 GroupNodeName;
        /* 0x30 */ public bool UseNodeParent;
        /* 0x31 */ public bool UseRaycast;
    }
}
