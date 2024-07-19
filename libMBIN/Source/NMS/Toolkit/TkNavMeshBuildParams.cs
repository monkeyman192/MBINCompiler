namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x617F49A484A6A1F5, NameHash = 0x3CABC6EE)]
    public class TkNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float AgentHeight;
        [NMS(Index = 4)]
        /* 0x04 */ public float AgentMaxSlopeDegrees;
        [NMS(Index = 3)]
        /* 0x08 */ public float AgentRadius;
        [NMS(Index = 12)]
        /* 0x0C */ public float ContourMaxError;
        [NMS(Index = 11)]
        /* 0x10 */ public float ContourMaxLength;
        [NMS(Index = 15)]
        /* 0x14 */ public float DetailMeshMaxError;
        [NMS(Index = 14)]
        /* 0x18 */ public float DetailMeshSampleDistance;
        [NMS(Index = 10)]
        /* 0x1C */ public int RegionMinCellCount;
        [NMS(Index = 0)]
        /* 0x20 */ public bool BuildAsync;
        [NMS(Index = 13)]
        /* 0x21 */ public bool BuildDetailMesh;
        [NMS(Index = 8)]
        /* 0x22 */ public bool ErodeWalkableAreas;
        [NMS(Index = 6)]
        /* 0x23 */ public bool FilterLedgeSpans;
        [NMS(Index = 5)]
        /* 0x24 */ public bool FilterLowHangingObstacles;
        [NMS(Index = 7)]
        /* 0x25 */ public bool FilterWalkableLowHeightSpans;
        [NMS(Index = 1)]
        /* 0x26 */ public bool KeepIntermediateRecastData;
        [NMS(Index = 9)]
        /* 0x27 */ public bool MedianFilterWalkableAreas;
    }
}
