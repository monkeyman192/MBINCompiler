using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55B215F681BBA72C, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCustomisationDescriptorGroupFallbackData> DescriptorGroupFallbackMap;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCustomisationPreset> Presets;
    }
}
