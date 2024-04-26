using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEB2E8E5ED50946A, NameHash = 0xBA72D7FB7D17FABE)]
    public class GcMinimumUseConstraint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> Modules;
        [NMS(Index = 1)]
        /* 0x20 */ public int MinUses;
    }
}
