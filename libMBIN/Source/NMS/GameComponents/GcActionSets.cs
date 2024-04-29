using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x632ED75C63217249, NameHash = 0x7D347F979E52A1C1)]
    public class GcActionSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSet> ActionSets;
    }
}
