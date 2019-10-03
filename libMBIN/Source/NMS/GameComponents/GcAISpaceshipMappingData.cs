using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, GUID = 0x544CC9937C378016, NameHash = 0xD67478E5FA6B9871)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        public GcAISpaceshipInstanceData[] ClassMap;
    }
}
