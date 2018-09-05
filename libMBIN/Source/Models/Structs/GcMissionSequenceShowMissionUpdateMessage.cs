namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8C)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        /* 0x0 */ public int MissionUpdateMessage;
        public string[] MissionUpdateMessageValues()
        {
            return new[] { "Start", "End" };
        }
        /* 0x4 */ public bool SetMissionSelected;
        /* 0x5 */ public bool WaitForMessageOver;
        /* 0x6 */ public bool ShowChangeMissionNotify;
        /* 0x8 */ public int PlayMusicSting;
        public string[] PlayMusicStingValues()
        {
            return new[] {"None", "Start", "End" };
        }
        [NMS(Size = 0x80)]
        /* 0xC */ public string DebugText;
    }
}
