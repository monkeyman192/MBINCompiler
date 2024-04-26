using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD03B9535BB7B5056, NameHash = 0xD67478E5FA6B9871)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
