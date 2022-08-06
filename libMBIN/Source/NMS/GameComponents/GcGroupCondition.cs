using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE1831995CF2F5F8, NameHash = 0x342750A176F374A4)]
    public class GcGroupCondition : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Conditions;
        /* 0x10 */ public bool ORConditions;
    }
}
