using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x880C0635D4CF2421, NameHash = 0x3820751A1F86DB6)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Conditions;
        /* 0x10 */ public GcMissionConditionTest ConditionTest;
        /* 0x14 */ public bool OnlyUsedForTextFormatting;
        /* 0x15 */ public bool ValueToReturnForTextFormatting;
    }
}
