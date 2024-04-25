using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF4BF89FC3D6D6F02, NameHash = 0xAF2831AAF7DE1710)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkSceneBoneRemapping> BoneMappings;
    }
}
