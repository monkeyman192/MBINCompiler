using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x994360644CAC52D2, NameHash = 0x434C17159AF37265)]
    public class GcScanEventSave : NMSTemplate
    {
        /* 0x00 */ public int Table;
        [NMS(Size = 4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x20 Event;
        /* 0x28 */ public ulong GalacticAddress;
        /* 0x30 */ public GcSeed BuildingSeed;
        /* 0x40 */ public Vector3f BuildingLocation;
        /* 0x50 */ public GcBuildingClassification BuildingClass;
        /* 0x54 */ public float Time;
        /* 0x58 */ public NMSString0x10 MissionID;
        /* 0x68 */ public ulong MissionSeed;
        /* 0x70 */ public GcPlayerMissionParticipantType ParticipantType;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
