using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E399CB3EC826048, NameHash = 0xFCD71DCE44349CB6)]
    public class GcStoryPageSeenDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStoryPageSeenData> PagesData;
    }
}
