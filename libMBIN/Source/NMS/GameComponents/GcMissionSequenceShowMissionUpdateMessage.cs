namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE266C4D1F9F6075, NameHash = 0x2431FBC75DE4AEB6)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CustomMessageLocID;
        /* 0x20 */ public NMSString0x20A CustomObjectiveLocID;
        // size: 0x2
        public enum MissionUpdateMessageEnum : uint {
            Start,
            End,
        }
        /* 0x40 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        // size: 0x4
        public enum PlayMusicStingEnum : uint {
            None,
            Start,
            End,
            Corrupted,
        }
        /* 0x44 */ public PlayMusicStingEnum PlayMusicSting;
        /* 0x48 */ public NMSString0x80 DebugText;
        /* 0xC8 */ public bool SetMissionSelected;
        /* 0xC9 */ public bool ShowChangeMissionNotify;
        /* 0xCA */ public bool WaitForMessageOver;
    }
}
