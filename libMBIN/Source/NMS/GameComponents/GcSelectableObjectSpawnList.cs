using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D66542595E273D3, NameHash = 0x5BC284B6)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSelectableObjectSpawnData> Objects;
    }
}
