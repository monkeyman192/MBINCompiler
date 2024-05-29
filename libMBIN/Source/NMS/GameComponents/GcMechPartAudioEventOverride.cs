using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE8294728EEB1505, NameHash = 0x8713A8C7BE9925C6)]
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
