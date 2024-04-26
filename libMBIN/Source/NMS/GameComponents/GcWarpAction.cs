namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD317F3DAC107BDAA, NameHash = 0x424B3146F5B3FC26)]
    public class GcWarpAction : NMSTemplate
    {
        // size: 0x2
        public enum WarpTypeEnum : uint {
            BlackHole,
            SpacePOI,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WarpTypeEnum WarpType;
    }
}
