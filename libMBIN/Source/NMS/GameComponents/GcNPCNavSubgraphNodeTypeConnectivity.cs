namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB06874149AD8811D, NameHash = 0xE692EE8E366F900)]
    public class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float ConnectionToPOI;
        [NMS(Index = 1)]
        /* 0x4 */ public float ExternalConnection;
        [NMS(Index = 0)]
        /* 0x8 */ public float InternalConnection;
        [NMS(Index = 2)]
        /* 0xC */ public float PathToPOI;
    }
}
