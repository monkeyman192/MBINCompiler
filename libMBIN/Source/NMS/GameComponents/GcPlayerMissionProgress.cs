using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C37BB9C92BD45AE, NameHash = 0x1611798444BC0C13)]
    public class GcPlayerMissionProgress : NMSTemplate
    {
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerMissionParticipantType.ParticipantTypeEnum))]
        /* 0x000 */ public GcPlayerMissionParticipant[] Participants;
        /* 0x270 */ public NMSString0x10 Mission;
        /* 0x280 */ public ulong Data;
        /* 0x288 */ public ulong Seed;
        /* 0x290 */ public ulong Stat;
        /* 0x298 */ public int Progress;
    }
}
