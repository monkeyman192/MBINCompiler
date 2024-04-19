using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E4F4CC93D9E0664, NameHash = 0xF1949393FDAF963A)]
    public class GcSeasonalStage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Description;
        /* 0x20 */ public NMSString0x20A Title;
        /* 0x40 */ public List<GcSeasonalMilestone> Milestones;
    }
}
