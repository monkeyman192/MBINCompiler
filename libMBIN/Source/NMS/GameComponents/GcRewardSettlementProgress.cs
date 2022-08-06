using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB63D04CD1DD3392, NameHash = 0x87616D37E129954C)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        /* 0x0 */ public bool UseInteractionBuildingType;
        /* 0x4 */ public GcBuildingClassification BuildingType;
    }
}
