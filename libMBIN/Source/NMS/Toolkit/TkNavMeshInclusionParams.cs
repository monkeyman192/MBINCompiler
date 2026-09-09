using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xED2853FF999E7978, NameHash = 0xA35B0A28)]
    public class TkNavMeshInclusionParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public bool ApplyMinSizeRequirements;
        [NMS(Index = 1)]
        /* 0x1 */ public TkNavMeshAreaType AreaType;
        [NMS(Index = 0)]
        /* 0x2 */ public TkNavMeshInclusionType InclusionType;
    }
}
