using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9D1095683FD17BE, NameHash = 0x5FB32B8921A7FE69)]
    public class TkLSystemLocatorEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 1)]
        /* 0x10 */ public float Probability;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x80 Model;
    }
}
