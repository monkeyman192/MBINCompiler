using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x573B7F5B56DC5AD3, NameHash = 0x156BFFBB5A2228FA)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        public GcWeatherColourSettingList GenericSettings;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        public GcWeatherColourSettingList[] PerBiomeSettings;
    }
}
