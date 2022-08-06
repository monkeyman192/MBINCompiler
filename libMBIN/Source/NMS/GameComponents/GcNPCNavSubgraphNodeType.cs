using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x598A5C64CDCE061D, NameHash = 0xBFFCA397C2DEA0EE)]
    public class GcNPCNavSubgraphNodeType : NMSTemplate
    {
        public enum NPCNavSubgraphNodeTypeEnum { Path, Connection, PointOfInterest }
        public NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType;
    }
}
