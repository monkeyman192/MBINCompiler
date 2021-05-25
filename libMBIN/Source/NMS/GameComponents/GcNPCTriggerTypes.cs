using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xD3740D8DFE14590C, NameHash = 0xED4A21D9F7E3058B)]
    public class GcNPCTriggerTypes : NMSTemplate
    {
        // size: 0xF
        public enum NPCTriggerEnum { None, Idle, Greet, Mood, StartDead, Talk_Start, Talk_Stop, Interact_Start, Interact_Stop, Interact_BeginHold, Interact_CancelHold, LookAt_Player_Start,
            LookAt_Player_Stop, SetProp, Interact_StartFromRemote }
        public NPCTriggerEnum NPCTrigger;
    }
}