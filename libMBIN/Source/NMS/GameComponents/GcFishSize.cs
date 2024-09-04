namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70CCB0159E755BBB, NameHash = 0x52B3609)]
    public class GcFishSize : NMSTemplate
    {
        // size: 0x4
        public enum FishSizeEnum : uint {
            Small,
            Medium,
            Large,
            ExtraLarge,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FishSizeEnum FishSize;
    }
}
