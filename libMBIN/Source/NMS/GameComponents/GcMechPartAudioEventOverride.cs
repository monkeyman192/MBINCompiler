using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BFFD332AB4BB295, NameHash = 0x46EB7A3E)]
    public class GcMechPartAudioEventOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMechMeshPart MeshPart;
        [NMS(Index = 1)]
        /* 0x4 */ public GcMechMeshType MeshType;
        [NMS(Index = 2)]
        /* 0x8 */ public GcAudioWwiseEvents OverrideEvent;
    }
}
