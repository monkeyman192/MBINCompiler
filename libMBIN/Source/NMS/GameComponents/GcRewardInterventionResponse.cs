namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7105FB962302E74C, NameHash = 0x3E904C2466567A08)]
    public class GcRewardInterventionResponse : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InterveneWithMissionID;
        /* 0x10 */ public int BasePercentOfMissionChanceSuccess;
        // size: 0x6
        public enum ResponseTypeEnum : uint {
            DontIntervene,
            InterveneWithMission,
            MissionSuccess,
            MissionFailure,
            MissionAvoid,
            MissionChance,
        }
        /* 0x14 */ public ResponseTypeEnum ResponseType;
    }
}
