using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x544CC9937C378016, NameHash = 0xD67478E5FA6B9871)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
