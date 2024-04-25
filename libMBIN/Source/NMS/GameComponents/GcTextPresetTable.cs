using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EF09080D6638588, NameHash = 0x6567927C2DD8F89F)]
    public class GcTextPresetTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTextPreset> Table;
    }
}
