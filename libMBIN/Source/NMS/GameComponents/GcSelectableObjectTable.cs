using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE467F6A1C222D57, NameHash = 0x8212F80B)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSelectableObjectList> Lists;
    }
}
