using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xD4DE3AE7B9F7F3F7, NameHash = 0xBBBD45634207B79F)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        /* 0x0 */ public bool AllowVehicles;
        /* 0x1 */ public bool AllowSpawnedObjects;
        /* 0x4 */ public int PowerCost;
        public enum EnabledRequirementEnum { BasePower, AbandonedFreighter }
        /* 0x8 */ public EnabledRequirementEnum EnabledRequirement;
    }
}