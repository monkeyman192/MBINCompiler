namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34827E14E7CDCAFA, NameHash = 0xED4A21D9F7E3058B)]
    public class GcNPCTriggerTypes : NMSTemplate
    {
        // size: 0xF
        public enum NPCTriggerEnum : uint {
            None,
            Idle,
            Greet,
            Mood,
            StartDead,
            Talk_Start,
            Talk_Stop,
            Interact_Start,
            Interact_Stop,
            Interact_BeginHold,
            Interact_CancelHold,
            LookAt_Player_Start,
            LookAt_Player_Stop,
            SetProp,
            Interact_StartFromRemote,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCTriggerEnum NPCTrigger;
    }
}
