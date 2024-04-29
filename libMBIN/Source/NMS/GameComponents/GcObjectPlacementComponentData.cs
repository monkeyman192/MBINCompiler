namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x887FA308DDE5E67D, NameHash = 0x6520972F5B89CD77)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        // size: 0x2
        public enum ActivationTypeEnum : uint {
            GroupNode,
            Locator,
        }
        [NMS(Index = 1)]
        /* 0x00 */ public ActivationTypeEnum ActivationType;
        [NMS(Index = 2)]
        /* 0x04 */ public float FractionOfNodesActive;
        [NMS(Index = 4)]
        /* 0x08 */ public int MaxGroupsActivated;
        [NMS(Index = 3)]
        /* 0x0C */ public int MaxNodesActivated;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 GroupNodeName;
        [NMS(Index = 6)]
        /* 0x30 */ public bool UseNodeParent;
        [NMS(Index = 5)]
        /* 0x31 */ public bool UseRaycast;
    }
}
