namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1D45EF58C5FFBC7B, NameHash = 0xE6019495)]
    public class TkNavMeshAgentFamilyConfig : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float LowHeightThreshold;
        [NMS(Index = 2)]
        /* 0x04 */ public float MaxAgentHeight;
        [NMS(Index = 0)]
        /* 0x08 */ public float MaxAgentRadius;
        [NMS(Index = 4)]
        /* 0x0C */ public float MaxShallowWaterDepth;
        [NMS(Index = 5)]
        /* 0x10 */ public float MaxStepHeight;
        [NMS(Index = 6)]
        /* 0x14 */ public float MinModifierInclusionSize;
        [NMS(Index = 3)]
        /* 0x18 */ public float MinShallowWaterDepth;
    }
}
