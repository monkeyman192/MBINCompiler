using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE5EE7B210672A91, NameHash = 0x1CD292C9)]
    public class GcTechBoxTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechBoxData> Table;
    }
}
