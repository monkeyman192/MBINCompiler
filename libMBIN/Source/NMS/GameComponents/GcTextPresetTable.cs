using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB4AEF3C8F40D735, NameHash = 0xE4EDA275)]
    public class GcTextPresetTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTextPreset> Table;
    }
}
