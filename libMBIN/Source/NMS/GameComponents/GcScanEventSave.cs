using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CC039A0229D5F8E, NameHash = 0x434C17159AF37265)]
    public class GcScanEventSave : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f BuildingLocation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x30 */ public GcSeed BuildingSeed;
        [NMS(Index = 7)]
        /* 0x40 */ public NMSString0x10 MissionID;
        [NMS(Index = 2)]
        /* 0x50 */ public ulong GalacticAddress;
        [NMS(Index = 8)]
        /* 0x58 */ public ulong MissionSeed;
        [NMS(Index = 5)]
        /* 0x60 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 9)]
        /* 0x64 */ public GcPlayerMissionParticipantType ParticipantType;
        [NMS(Index = 0)]
        /* 0x68 */ public int Table;
        [NMS(Index = 6)]
        /* 0x6C */ public float Time;
    }
}
