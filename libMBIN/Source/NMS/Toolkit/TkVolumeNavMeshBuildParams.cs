using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x136903FE66BABD61, NameHash = 0x253FE95)]
    public class TkVolumeNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector3f FixedBoundsMax;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector3f FixedBoundsMin;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Id;
        [NMS(Index = 6, Size = 0x5, EnumType = typeof(TkNavMeshAgentFamily.NavMeshAgentFamilyEnum))]
        /* 0x40 */ public TkVolumeNavMeshFamilyBuildParams[] FamilyBuildParams;
        [NMS(Index = 1)]
        /* 0x90 */ public float ActivationDistance;
        [NMS(Index = 2)]
        /* 0x94 */ public float DeactivationBufferDistance;
        // size: 0x4
        public enum VolumeNavMeshBoundsMethodEnum : uint {
            Resource,
            ModelNode,
            Fixed,
            MarkupVolumes,
        }
        [NMS(Index = 3)]
        /* 0x98 */ public VolumeNavMeshBoundsMethodEnum VolumeNavMeshBoundsMethod;
    }
}
