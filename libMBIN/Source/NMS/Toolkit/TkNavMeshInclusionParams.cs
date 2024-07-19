using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7ED5C1D86467E4F1, NameHash = 0xA35B0A28)]
    public class TkNavMeshInclusionParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public TkNavMeshAreaType AreaType;
        [NMS(Index = 1)]
        /* 0x4 */ public float InclusionMinSize;
        [NMS(Index = 0)]
        /* 0x8 */ public TkNavMeshInclusionType InclusionType;
    }
}
