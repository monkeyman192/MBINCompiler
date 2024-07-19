using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42B96E6C683A52C7, NameHash = 0x8CFEB3CA)]
    public class GcHeavyAirList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<VariableSizeString> Options;
    }
}
