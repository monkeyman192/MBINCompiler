namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89F8ED6A89A7E06A, NameHash = 0x1A55832)]
    public class DirectMesh : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int NumPointsInDirectMeshI;
        [NMS(Index = 2)]
        /* 0x04 */ public int NumPointsInDirectMeshJ;
        [NMS(Index = 3)]
        /* 0x08 */ public int NumSimPointsI;
        [NMS(Index = 4)]
        /* 0x0C */ public int NumSimPointsJ;
        [NMS(Index = 5)]
        /* 0x10 */ public int VertexOrdering;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x40 NodeName;
        [NMS(Index = 6)]
        /* 0x54 */ public bool RenderVertexBasedCloth;
    }
}
