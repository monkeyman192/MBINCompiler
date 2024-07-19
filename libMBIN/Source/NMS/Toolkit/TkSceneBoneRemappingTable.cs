using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDDE5E354D3AE4600, NameHash = 0xDDAD118A)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkSceneBoneRemapping> BoneMappings;
    }
}
