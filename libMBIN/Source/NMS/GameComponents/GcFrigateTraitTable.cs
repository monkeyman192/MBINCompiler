using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA94AE1B5A9BB2D53, NameHash = 0xA6A94B5FC4AC3D18)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateTraitData> Traits;
    }
}
