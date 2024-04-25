namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFC67D2D7540961D5, NameHash = 0xFCAC758E3056BFEF)]
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
