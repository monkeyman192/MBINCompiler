using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xB84FEECD3EC4E5E8, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        public List<GcCustomisationPreset> Presets;
    }
}
