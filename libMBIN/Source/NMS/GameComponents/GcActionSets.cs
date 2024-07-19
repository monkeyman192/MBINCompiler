using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74CD0ED38484BA9B, NameHash = 0xC212E44)]
    public class GcActionSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSet> ActionSets;
    }
}
