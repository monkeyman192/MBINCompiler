namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D261DAAE380CE54, NameHash = 0x17E179C0)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomMessageLocID;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A CustomObjectiveLocID;
        [NMS(Index = 8)]
        /* 0x40 */ public VariableSizeString DebugText;
        // size: 0x2
        public enum MissionUpdateMessageEnum : uint {
            Start,
            End,
        }
        [NMS(Index = 0)]
        /* 0x50 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        // size: 0x4
        public enum PlayMusicStingEnum : uint {
            None,
            Start,
            End,
            Corrupted,
        }
        [NMS(Index = 7)]
        /* 0x54 */ public PlayMusicStingEnum PlayMusicSting;
        [NMS(Index = 3)]
        /* 0x58 */ public bool SetMissionSelected;
        [NMS(Index = 5)]
        /* 0x59 */ public bool ShowChangeMissionNotify;
        [NMS(Index = 6)]
        /* 0x5A */ public bool SuppressNotificationsNotFromThisMission;
        [NMS(Index = 4)]
        /* 0x5B */ public bool WaitForMessageOver;
    }
}
