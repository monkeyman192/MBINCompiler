namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F2BA459DCEC25BC, NameHash = 0x3C426079)]
    public class GcRewardTeleport : NMSTemplate
    {
        // size: 0x7
        public enum TeleportRewardTypeEnum : uint {
            None,
            ToBase,
            Station0,
            Station1,
            Station2,
            Station3,
            Atlas,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TeleportRewardTypeEnum TeleportRewardType;
    }
}
