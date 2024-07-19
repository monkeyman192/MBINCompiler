namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7D3BCFD9AF68C66, NameHash = 0x4DB7C299)]
    public class TkNavMeshInclusionType : NMSTemplate
    {
        // size: 0x4
        public enum NavMeshInclusionTypeEnum : uint {
            Auto,
            Ignore,
            Obstacle,
            Walkable,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshInclusionTypeEnum NavMeshInclusionType;
    }
}
