using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF62EDC295BDA0446, NameHash = 0x9D94FFAB)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 2)]
        /* 0x10 */ public GcAISpaceshipRoles AIRole;
        [NMS(Index = 1)]
        /* 0x14 */ public GcSpaceshipClasses Class;
        [NMS(Index = 3)]
        /* 0x18 */ public GcFrigateClass FrigateClass;
    }
}
