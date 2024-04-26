using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80252ED3F7EE7A09, NameHash = 0xCE1983E849879238)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSelectableObjectList> Lists;
    }
}
