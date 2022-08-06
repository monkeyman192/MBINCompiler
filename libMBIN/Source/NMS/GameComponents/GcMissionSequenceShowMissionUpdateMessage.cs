using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCF0CBC38A5AD177, NameHash = 0x2431FBC75DE4AEB6)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
		public enum MissionUpdateMessageEnum { Start, End }
		/* 0x00 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        /* 0x08 */ public NMSString0x20A CustomMessageLocID;
        /* 0x28 */ public NMSString0x20A CustomObjectiveLocID;
        /* 0x48 */ public bool SetMissionSelected;
        /* 0x49 */ public bool WaitForMessageOver;
        /* 0x4A */ public bool ShowChangeMissionNotify;
		public enum PlayMusicStingEnum { None, Start, End }
		/* 0x4C */ public PlayMusicStingEnum PlayMusicSting;
        /* 0x50 */ public NMSString0x80 DebugText;
    }
}
