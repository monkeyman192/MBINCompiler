using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E0DE8B5D61BED85, NameHash = 0x80A3A41E)]
    public class GcPlayerMissionParticipant : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f BuildingLocation;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSeed BuildingSeed;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong UA;
        [NMS(Index = 3)]
        /* 0x28 */ public GcPlayerMissionParticipantType ParticipantType;
    }
}
