using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0AE546883EEB9CC, NameHash = 0xE4BF25FD)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
