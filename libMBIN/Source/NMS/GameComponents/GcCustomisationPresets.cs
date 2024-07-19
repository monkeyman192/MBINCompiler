using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x981AD133D3E5FDDF, NameHash = 0xFE6613FE)]
    public class GcCustomisationPresets : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCustomisationDescriptorGroupFallbackData> DescriptorGroupFallbackMap;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCustomisationPreset> Presets;
    }
}
