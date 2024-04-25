namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81663F7AA75A4A81, NameHash = 0xE727C698F36AF1CA)]
    public class GcBehaviourLegacyData : NMSTemplate
    {
        // size: 0x9
        public enum LegacyBehaviourEnum : uint {
            Riding,
            Interaction,
            Attracted,
            Flee,
            Defend,
            FollowPlayer,
            AvoidPlayer,
            NoticePlayer,
            FollowRoutine,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LegacyBehaviourEnum LegacyBehaviour;
    }
}
