using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD23005B150B0E6B1, NameHash = 0x6E90E2A796E798F4)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5)]
        /* 0x0 */ public GcHeavyAirSettingValues[] Settings;
    }
}
