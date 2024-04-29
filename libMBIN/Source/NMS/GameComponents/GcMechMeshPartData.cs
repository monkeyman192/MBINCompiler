using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DDA9BBA0BA31F39, NameHash = 0xE780BADC17E2668A)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
