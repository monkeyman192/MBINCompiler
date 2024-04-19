using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD698FFCE91C4847, NameHash = 0x5035CC19B55D3442)]
    public class GcSelectableObjectList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<GcSelectableObjectData> Options;
        /* 0x20 */ public GcAlienRace Race;
    }
}
