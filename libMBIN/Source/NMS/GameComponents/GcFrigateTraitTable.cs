using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD0EAD3840328781D, NameHash = 0xA6A94B5FC4AC3D18)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        public List<GcFrigateTraitData> Traits;
    }
}
