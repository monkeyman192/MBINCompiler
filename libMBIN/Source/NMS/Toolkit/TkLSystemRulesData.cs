using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemRulesData : NMSTemplate
    {
        public List<TkLSystemGlobalRestriction> GlobalRestriction;

        public List<TkLSystemGlobalVariation> GlobalVariation;

        public List<TkLSystemRule> Rules;

        public List<TkLSystemRuleTemplate> Templates;
    }
}
