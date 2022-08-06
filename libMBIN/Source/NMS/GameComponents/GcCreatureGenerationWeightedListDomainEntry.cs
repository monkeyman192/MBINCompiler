using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22A91C35B30D291A, NameHash = 0x823BF33F97DC4F32)]
    public class GcCreatureGenerationWeightedListDomainEntry : NMSTemplate
    {
        /* 0x0 */ public float Weight;
        /* 0x8 */ public NMSString0x10 Archetype;
    }
}
