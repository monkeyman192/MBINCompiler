using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19F36C23AB4420C6, NameHash = 0x38A772FD)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcMechMeshPart.MechMeshPartEnum))]
        /* 0x0 */ public GcMechMeshPartData[] Parts;
    }
}
