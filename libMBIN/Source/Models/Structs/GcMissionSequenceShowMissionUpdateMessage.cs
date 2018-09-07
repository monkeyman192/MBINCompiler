namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8C)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
		public enum MissionUpdateMessageEnum { Start, End }
		public MissionUpdateMessageEnum MissionUpdateMessage;
        /* 0x4 */ public bool SetMissionSelected;
        /* 0x5 */ public bool WaitForMessageOver;
        /* 0x6 */ public bool ShowChangeMissionNotify;
		public enum PlayMusicStingEnum { None, Start, End }
		public PlayMusicStingEnum PlayMusicSting;
        [NMS(Size = 0x80)]
        /* 0xC */ public string DebugText;
    }
}
