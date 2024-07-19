namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE0E9DF6D9E4C2D3, NameHash = 0x86571BD1)]
    public class GcRewardShipAssistance : NMSTemplate
    {
        // size: 0x2
        public enum AssistanceTypeEnum : uint {
            Police,
            Wingmen,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AssistanceTypeEnum AssistanceType;
        [NMS(Index = 1)]
        /* 0x4 */ public float Time;
    }
}
