using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x48075AB280866351, NameHash = 0xF3B44A34)]
    public class TkNavMeshPathingQualitySettings : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkNavMeshVelocitySamplingParams VelocitySamplingParams;
        [NMS(Index = 2)]
        /* 0x3C */ public float CollisionQueryRange;
        [NMS(Index = 0)]
        /* 0x40 */ public float HeuristicScale;
        [NMS(Index = 1)]
        /* 0x44 */ public bool UseRaycastShortcuts;
    }
}
