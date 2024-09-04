namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA22EE6E5E8EE5EF8, NameHash = 0x7CEB3842)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0x1B
        public enum ProceduralProductCategoryEnum : uint {
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
            FreighterPassword,
            FreighterCaptLog,
            FreighterCrewList,
            FreighterTechHyp,
            FreighterTechSpeed,
            FreighterTechFuel,
            FreighterTechTrade,
            FreighterTechCombat,
            FreighterTechMine,
            FreighterTechExp,
            DismantleBio,
            DismantleTech,
            DismantleData,
            MessageInBottle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
