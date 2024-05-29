using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEC2F6A050861E0, NameHash = 0xA6A94B5FC4AC3D18)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateTraitData> Traits;
    }
}
