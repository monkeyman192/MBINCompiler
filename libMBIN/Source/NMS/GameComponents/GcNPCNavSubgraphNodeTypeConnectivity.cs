using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B1C6E85AF36DC61, NameHash = 0xE692EE8E366F900)]
    public class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
    {
        /* 0x0 */ public float InternalConnection;
        /* 0x4 */ public float ExternalConnection;
        /* 0x8 */ public float PathToPOI;
        /* 0xC */ public float ConnectionToPOI;
    }
}
