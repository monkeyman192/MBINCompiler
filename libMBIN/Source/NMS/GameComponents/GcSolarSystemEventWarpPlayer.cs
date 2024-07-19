using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37D97F79A81490CF, NameHash = 0x2CF3B42B)]
    public class GcSolarSystemEventWarpPlayer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        [NMS(Index = 1)]
        /* 0x2C */ public float Time;
    }
}
