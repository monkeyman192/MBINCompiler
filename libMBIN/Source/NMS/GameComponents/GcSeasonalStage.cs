using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A1749DC1332920, NameHash = 0xC3D2D172)]
    public class GcSeasonalStage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 0)]
        /* 0x40 */ public List<GcSeasonalMilestone> Milestones;
    }
}
