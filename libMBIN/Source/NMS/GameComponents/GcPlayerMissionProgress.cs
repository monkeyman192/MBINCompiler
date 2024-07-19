using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8F1D1ADFF493912, NameHash = 0x6D4B45E2)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        [NMS(Index = 5, Size = 0xD, EnumType = typeof(GcPlayerMissionParticipantType.ParticipantTypeEnum))]
        /* 0x000 */ public GcPlayerMissionParticipant[] Participants;
        [NMS(Index = 0)]
        /* 0x270 */ public NMSString0x10 Mission;
        [NMS(Index = 3)]
        /* 0x280 */ public ulong Data;
        [NMS(Index = 2)]
        /* 0x288 */ public ulong Seed;
        [NMS(Index = 4)]
        /* 0x290 */ public ulong Stat;
        [NMS(Index = 1)]
        /* 0x298 */ public int Progress;
    }
}
