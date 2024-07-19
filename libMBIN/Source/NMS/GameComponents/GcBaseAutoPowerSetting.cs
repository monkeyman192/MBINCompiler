namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD00027FD44908DFE, NameHash = 0x90BB59B4)]
    public class GcBaseAutoPowerSetting : NMSTemplate
    {
        // size: 0x3
        public enum BaseAutoPowerSettingEnum : uint {
            UseDefault,
            ForceDisabled,
            ForceEnabled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseAutoPowerSettingEnum BaseAutoPowerSetting;
    }
}
