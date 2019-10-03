using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x73B06516A6D7F9C9, NameHash = 0x8ECE9ECB68A7E994)]
    public class TkLSystemRulesData : NMSTemplate
    {
        public List<TkLSystemGlobalRestriction> GlobalRestriction;

        public List<TkLSystemGlobalVariation> GlobalVariation;

        public List<TkLSystemRule> Rules;

        public List<TkLSystemRuleTemplate> Templates;
    }
}
