namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA38DFDDC656C39DD, NameHash = 0xBBC2C9E7EE1270B0)]
    public class GcInteractionMissionState : NMSTemplate
    {
        // size: 0x4
        public enum InteractionMissionStateEnum : uint {
            Unused,
            Unlocked,
            MonoCorrupted,
            GiftGiven,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InteractionMissionStateEnum InteractionMissionState;
    }
}
