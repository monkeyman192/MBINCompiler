namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x786DE8497EEECF6E, NameHash = 0x63DF31AD)]
    public class GcWonderTreasureCategory : NMSTemplate
    {
        // size: 0xD
        public enum WonderTreasureCategoryEnum : uint {
            Loot,
            Document,
            BioSample,
            Fossil,
            Plant,
            Tool,
            Farm,
            SeaLoot,
            SeaHorror,
            Salvage,
            Bones,
            SpaceHorror,
            SpaceBones,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderTreasureCategoryEnum WonderTreasureCategory;
    }
}
