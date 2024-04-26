using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B5B90DEE45BDA9B, NameHash = 0xB4862F5009F24854)]
    public class GcSolarSystemEventWarpPlayer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        [NMS(Index = 1)]
        /* 0x2C */ public float Time;
    }
}
