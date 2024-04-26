namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB8B17B3CC5FF674, NameHash = 0xC66C80C1B41A77FD)]
    public class GcSolarSystemClass : NMSTemplate
    {
        // size: 0x4
        public enum SolarSystemClassEnum : uint {
            Default,
            Initial,
            Anomaly,
            GameStart,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SolarSystemClassEnum SolarSystemClass;
    }
}
