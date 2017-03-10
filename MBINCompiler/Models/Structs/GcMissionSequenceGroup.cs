using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceGroup : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        public int Behaviour;
        /* 0x080 */ public string[] BehaviourValues()
        {
            return new[] { "SkipIfConditionFails", "RepeatIfConditionFails", "RepeatWhileConditionTrue" };
        }
        /* 0x088 */ public List<NMSTemplate> Conditions;
        /* 0x098 */ public List<NMSTemplate> Consequences;
        /* 0x0A8 */ public List<NMSTemplate> NotificationSequence;
    }
}
