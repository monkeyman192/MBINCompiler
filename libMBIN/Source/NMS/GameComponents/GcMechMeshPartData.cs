using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34568663B0B49A62, NameHash = 0xE780BADC17E2668A)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
