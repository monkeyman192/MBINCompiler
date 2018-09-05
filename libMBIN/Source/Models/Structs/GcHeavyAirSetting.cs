namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA0)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
