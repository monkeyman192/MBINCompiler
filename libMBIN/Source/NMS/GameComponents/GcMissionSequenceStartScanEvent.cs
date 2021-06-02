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
        /* 0x008 */ public NMSString0x20 Event;
        /* 0x028 */ public float Time;
        /* 0x02C */ public bool AllowOtherPlayerBase;
        /* 0x02D */ public NMSString0x80 DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
