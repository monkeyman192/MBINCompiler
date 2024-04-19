namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FD0C1C87EC33795, NameHash = 0xE692EE8E366F900)]
    public class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
    {
        /* 0x0 */ public float ConnectionToPOI;
        /* 0x4 */ public float ExternalConnection;
        /* 0x8 */ public float InternalConnection;
        /* 0xC */ public float PathToPOI;
    }
}
