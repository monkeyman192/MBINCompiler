using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5478DF05A57C0BE, NameHash = 0x3451351D9009735E)]
    public class GcRewardSpecialFromList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A TextFormat;
        /* 0x20 */ public List<NMSString0x10> FallbackList;
        /* 0x30 */ public List<NMSString0x10> PriorityList;
    }
}
