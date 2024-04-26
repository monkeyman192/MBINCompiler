namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCAA6E426437853B, NameHash = 0xE46F247D87F34DBC)]
    public class GcProceduralTechnologyCategory : NMSTemplate
    {
        // size: 0x5
        public enum ProceduralTechnologyCategoryEnum : uint {
            None,
            Combat,
            Mining,
            Scanning,
            Protection,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProceduralTechnologyCategoryEnum ProceduralTechnologyCategory;
    }
}
