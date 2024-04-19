using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3AE3A456D5961195, NameHash = 0x434C17159AF37265)]
    public class GcScanEventSave : NMSTemplate
    {
        /* 0x00 */ public Vector3f BuildingLocation;
        /* 0x10 */ public NMSString0x20A Event;
        /* 0x30 */ public GcSeed BuildingSeed;
        /* 0x40 */ public NMSString0x10 MissionID;
        /* 0x50 */ public ulong GalacticAddress;
        /* 0x58 */ public ulong MissionSeed;
        /* 0x60 */ public GcBuildingClassification BuildingClass;
        /* 0x64 */ public GcPlayerMissionParticipantType ParticipantType;
        /* 0x68 */ public int Table;
        /* 0x6C */ public float Time;
    }
}
