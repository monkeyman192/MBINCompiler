using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A54669EC5CBF6CB, NameHash = 0x86EB95060E94C279)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcMechMeshPart.MechMeshPartEnum))]
        /* 0x0 */ public GcMechMeshPartData[] Parts;
    }
}
