using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE2398BAB8E7E78C, NameHash = 0x46AEF7A8E9B9A7D8)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public int[] Counts;
    }
}
