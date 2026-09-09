using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EC89418EDBD2112, NameHash = 0xE3058C06)]
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
