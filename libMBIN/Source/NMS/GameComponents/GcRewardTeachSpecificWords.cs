using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAC99872D8E1DCFB, NameHash = 0xB52FD92EE85259A)]
    public class GcRewardTeachSpecificWords : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A CustomOSDMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x20A> SpecificWordGroups;
        [NMS(Index = 2)]
        /* 0x30 */ public float OSDMessageTime;
        [NMS(Index = 0)]
        /* 0x34 */ public GcAlienRace Race;
        [NMS(Index = 4)]
        /* 0x38 */ public bool SuppressOSDMessage;
    }
}
