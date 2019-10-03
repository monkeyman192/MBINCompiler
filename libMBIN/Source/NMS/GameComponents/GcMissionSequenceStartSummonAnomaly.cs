using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8723C02E06E012CC, NameHash = 0x6AFB1C1263D2F6F3)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate      // size: 0x88
    {
        /* 0x000 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x004 */ public float SummonInFrontDistance;
        [NMS(Size = 0x80)]
        /* 0x008 */ public string DebugText;
    }
}
