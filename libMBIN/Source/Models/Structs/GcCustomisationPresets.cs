using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcCustomisationPresets : NMSTemplate
    {
        public List<GcCustomisationPreset> Presets;
    }
}
