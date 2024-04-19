using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x800D4593B5370A32, NameHash = 0x5FB32B8921A7FE69)]
    public class TkLSystemLocatorEntry : NMSTemplate
    {
        /* 0x00 */ public List<TkLSystemRestrictionData> Restrictions;
        /* 0x10 */ public float Probability;
        /* 0x14 */ public NMSString0x80 Model;
    }
}
