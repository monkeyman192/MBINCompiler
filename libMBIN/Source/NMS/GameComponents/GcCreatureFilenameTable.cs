using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA270C96BA5305A0A, NameHash = 0x2FBFB424)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFilename> Table;
    }
}
