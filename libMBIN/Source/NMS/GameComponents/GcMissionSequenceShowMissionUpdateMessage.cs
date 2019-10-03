using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, GUID = 0x5A9999D7A5C69B32, NameHash = 0x2431FBC75DE4AEB6)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
		public enum MissionUpdateMessageEnum { Start, End }
		/* 0x00 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x08 */ public string CustomMessageLocID;
        /* 0x28 */ public bool SetMissionSelected;
        /* 0x29 */ public bool WaitForMessageOver;
        /* 0x2A */ public bool ShowChangeMissionNotify;
		public enum PlayMusicStingEnum { None, Start, End }
		/* 0x2C */ public PlayMusicStingEnum PlayMusicSting;
        [NMS(Size = 0x80)]
        /* 0x30 */ public string DebugText;
    }
}
