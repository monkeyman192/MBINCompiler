using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD1873CF2537D67, NameHash = 0xE727C698F36AF1CA)]
    public class GcBehaviourLegacyData : NMSTemplate
    {
        // size: 0x9
        public enum LegacyBehaviourEnum { Riding, Interaction, Attracted, Flee, Defend, FollowPlayer, AvoidPlayer, NoticePlayer, FollowRoutine }
        public LegacyBehaviourEnum LegacyBehaviour;
    }
}
