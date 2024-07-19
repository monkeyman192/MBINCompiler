namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB5B13115C4843E7, NameHash = 0x34C07963)]
    public class GcWonderMineralCategory : NMSTemplate
    {
        // size: 0x8
        public enum WonderMineralCategoryEnum : uint {
            GeneralFact0,
            GeneralFact1,
            GeneralFact2,
            MetalFact,
            ColdFact,
            HotFact,
            RadFact,
            ToxFact,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderMineralCategoryEnum WonderMineralCategory;
    }
}
