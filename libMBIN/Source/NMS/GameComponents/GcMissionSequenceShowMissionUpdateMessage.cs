namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE266C4D1F9F6075, NameHash = 0x2431FBC75DE4AEB6)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomMessageLocID;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A CustomObjectiveLocID;
        // size: 0x2
        public enum MissionUpdateMessageEnum : uint {
            Start,
            End,
        }
        [NMS(Index = 0)]
        /* 0x40 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        // size: 0x4
        public enum PlayMusicStingEnum : uint {
            None,
            Start,
            End,
            Corrupted,
        }
        [NMS(Index = 6)]
        /* 0x44 */ public PlayMusicStingEnum PlayMusicSting;
        [NMS(Index = 7)]
        /* 0x48 */ public NMSString0x80 DebugText;
        [NMS(Index = 3)]
        /* 0xC8 */ public bool SetMissionSelected;
        [NMS(Index = 5)]
        /* 0xC9 */ public bool ShowChangeMissionNotify;
        [NMS(Index = 4)]
        /* 0xCA */ public bool WaitForMessageOver;
    }
}
