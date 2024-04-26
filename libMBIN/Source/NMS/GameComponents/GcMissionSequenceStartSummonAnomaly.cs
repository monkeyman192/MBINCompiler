using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0ECCFBDAC455333, NameHash = 0x6AFB1C1263D2F6F3)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
        [NMS(Index = 1)]
        /* 0x4 */ public float SummonInFrontDistance;
        [NMS(Index = 2)]
        /* 0x8 */ public NMSString0x80 DebugText;
    }
}
