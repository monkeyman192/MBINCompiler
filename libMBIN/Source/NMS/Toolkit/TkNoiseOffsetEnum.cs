namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFC67D2D7540961D5, NameHash = 0x14DCEE1B)]
    public class TkNoiseOffsetEnum : NMSTemplate
    {
        // size: 0x4
        public enum OffsetTypeEnum : uint {
            Zero,
            Base,
            All,
            SeaLevel,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public OffsetTypeEnum OffsetType;
    }
}
