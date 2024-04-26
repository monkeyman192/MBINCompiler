using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x880C0635D4CF2421, NameHash = 0x3820751A1F86DB6)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 2)]
        /* 0x10 */ public GcMissionConditionTest ConditionTest;
        [NMS(Index = 0)]
        /* 0x14 */ public bool OnlyUsedForTextFormatting;
        [NMS(Index = 1)]
        /* 0x15 */ public bool ValueToReturnForTextFormatting;
    }
}
