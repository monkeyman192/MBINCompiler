using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, Alignment = 0x8, GUID = 0x90CF75D7BA76F02A, NameHash = 0x84E26BAA3B367507)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        public enum ScanTableEnum { Space, Planet, Missions, Tutorial, MissionsCreative, Vehicle, NPCPlanetSite, Seasonal };
        /* 0x000 */ public ScanTableEnum ScanTable;
        /* 0x004 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Size = 0x20)]
        /* 0x008 */ public string Event;
        /* 0x028 */ public float Time;
        /* 0x02C */ public bool AllowOtherPlayerBase;
        [NMS(Size = 0x80)]
        /* 0x02D */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
