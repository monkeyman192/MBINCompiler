namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E1F49265C04A9DD, NameHash = 0x289BCE0F)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 MissionNoGroundCombat;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 MissionNoSpaceCombat;
        [NMS(Index = 5)]
        /* 0x30 */ public bool ForceUseConversationSeed;
        [NMS(Index = 3)]
        /* 0x31 */ public bool InheritActiveMultiplayerMissionSeed;
        [NMS(Index = 4)]
        /* 0x32 */ public bool SelectMissionAsLocalMissionBoard;
    }
}
