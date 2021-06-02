using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x8723C02E06E012CC, NameHash = 0x6AFB1C1263D2F6F3)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate      // size: 0x88
    {
        /* 0x000 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x004 */ public float SummonInFrontDistance;
        /* 0x008 */ public NMSString0x80 DebugText;
    }
}