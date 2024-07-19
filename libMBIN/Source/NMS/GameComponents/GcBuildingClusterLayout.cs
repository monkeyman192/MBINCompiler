using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EAAC06DD888707F, NameHash = 0x93FF0D35)]
    public class GcBuildingClusterLayout : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcBuildingClusterLayoutEntry> ClusterBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x20 */ public float AlignmentJitter;
        [NMS(Index = 3)]
        /* 0x24 */ public int AlignmentSteps;
        [NMS(Index = 1)]
        /* 0x28 */ public float RelativeProbability;
    }
}
