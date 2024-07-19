namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22072DF17EC2DAE, NameHash = 0xE1645A55)]
    public class GcSentinelCoverState : NMSTemplate
    {
        // size: 0x4
        public enum SentinelCoverStateEnum : uint {
            Deploying,
            Deployed,
            ShuttingDown,
            ShutDown,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelCoverStateEnum SentinelCoverState;
    }
}
