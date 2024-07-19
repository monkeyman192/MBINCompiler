using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC92B4F2A77FAA75C, NameHash = 0xD8CBF616)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5)]
        /* 0x0 */ public GcHeavyAirSettingValues[] Settings;
    }
}
