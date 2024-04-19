using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15CC92894B7D147B, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationDescriptorGroupFallbackData> DescriptorGroupFallbackMap;
        /* 0x10 */ public List<GcCustomisationPreset> Presets;
    }
}
