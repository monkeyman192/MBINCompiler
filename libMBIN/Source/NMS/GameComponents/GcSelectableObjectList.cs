using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95DAABADB0E4A69F, NameHash = 0x5035CC19B55D3442)]
    public class GcSelectableObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcSelectableObjectData> Options;
        [NMS(Index = 1)]
        /* 0x20 */ public GcAlienRace Race;
    }
}
