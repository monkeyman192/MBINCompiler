using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x210DE14A2D00EF72, NameHash = 0x792FD0F5EBBA55E9)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcDamageMultiplier> Multipliers;
        /* 0x20 */ public float Default;
    }
}
