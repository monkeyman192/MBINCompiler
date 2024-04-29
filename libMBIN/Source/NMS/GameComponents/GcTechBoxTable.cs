using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86F8EEBFE6102CAD, NameHash = 0x932307388A9E5FF3)]
    public class GcTechBoxTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechBoxData> Table;
    }
}
