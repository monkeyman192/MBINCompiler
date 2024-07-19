using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB57C1958C4663352, NameHash = 0x7BFA6E42)]
    public class GcCreatureRoleFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureRoleFilename> Options;
    }
}
