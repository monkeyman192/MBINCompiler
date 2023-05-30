using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
