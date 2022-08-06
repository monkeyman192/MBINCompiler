using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x42A5538826CCFAB4, NameHash = 0x67494CEE3CE0F9F6)]
    public class GcCostWordKnowledge : NMSTemplate
    {
        public GcAlienRace Race;
        public enum RequirementEnum { CanLearn, CanSpeak }
        public RequirementEnum Requirement;
    }
}