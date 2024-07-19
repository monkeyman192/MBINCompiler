using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x53A5E27ED3BC0E3A, NameHash = 0x8C5F8D87)]
    public class TkLSystemRulesData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkLSystemGlobalRestriction> GlobalRestriction;
        [NMS(Index = 1)]
        /* 0x10 */ public List<TkLSystemGlobalVariation> GlobalVariation;
        [NMS(Index = 2)]
        /* 0x20 */ public List<TkLSystemRule> Rules;
        [NMS(Index = 3)]
        /* 0x30 */ public List<TkLSystemRuleTemplate> Templates;
    }
}
