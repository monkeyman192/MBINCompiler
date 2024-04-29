using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x436F8D2291DA99BC, NameHash = 0x963F45EDCB1413E2)]
    public class GcCreatureRoleFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureRoleFilename> Options;
    }
}
