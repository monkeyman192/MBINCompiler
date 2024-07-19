using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x428A325C4AF09633, NameHash = 0x7D0EF698)]
    public class GcStoryPageSeenDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStoryPageSeenData> PagesData;
    }
}
