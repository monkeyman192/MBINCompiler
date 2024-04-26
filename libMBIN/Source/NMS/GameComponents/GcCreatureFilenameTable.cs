using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD72EFA0ECE1FAFA0, NameHash = 0x5F5BF3F7E2ECA606)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFilename> Table;
    }
}
