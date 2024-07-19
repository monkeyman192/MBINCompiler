namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB26B41C33871BBB, NameHash = 0xABB014E4)]
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
        // size: 0x6
        public enum ResponseEnum : uint {
            StayOut,
            ReturnHome,
            CheckForMoreDamage,
            ShowDamagedCaptain,
            ShowExpeditionCaptain,
            AbortExpedition,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ResponseEnum Response;
    }
}
