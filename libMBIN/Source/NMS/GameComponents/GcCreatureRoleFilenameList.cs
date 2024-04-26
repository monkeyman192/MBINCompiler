using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98342C1E58BC7D1F, NameHash = 0x963F45EDCB1413E2)]
    public class GcCreatureRoleFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureRoleFilename> Options;
    }
}
