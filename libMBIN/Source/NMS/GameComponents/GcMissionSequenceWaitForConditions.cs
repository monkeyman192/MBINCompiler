using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, Alignment = 0x8, GUID = 0x447961099A4C8366, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        /* 0x098 */ public bool AllowedToFormatObjectives;
        [NMS(Size = 0x80)]
        /* 0x099 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x119 */ public byte[] Padding119;
        /* 0x11C */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
    }
}
