namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x666451205CCD88E3, NameHash = 0x6CDE5305)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultProductTypeEnum : uint {
            None,
            PrimaryProduct,
            SecondaryProduct,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DefaultProductTypeEnum DefaultProductType;
    }
}
