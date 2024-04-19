namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF01A7F2F3C1F7A5, NameHash = 0x71B9EA7C3B789C6B)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public NMSString0x10 MissionNoGroundCombat;
        /* 0x20 */ public NMSString0x10 MissionNoSpaceCombat;
        /* 0x30 */ public bool ForceUseConversationSeed;
        /* 0x31 */ public bool InheritActiveMultiplayerMissionSeed;
        /* 0x32 */ public bool SelectMissionAsLocalMissionBoard;
    }
}
