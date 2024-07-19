using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37DFEB127A3DFA86, NameHash = 0x2F76F833)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
