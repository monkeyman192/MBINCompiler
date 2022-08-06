using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6984342C6BFF9F3, NameHash = 0x8A9F48B72B9E5588)]
    public class GcBuildingClusterLayout : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float RelativeProbability;
        /* 0x18 */ public List<GcBuildingClusterLayoutEntry> ClusterBuildings;
        /* 0x28 */ public int AlignmentSteps;
        /* 0x2C */ public float AlignmentJitter;
    }
}
