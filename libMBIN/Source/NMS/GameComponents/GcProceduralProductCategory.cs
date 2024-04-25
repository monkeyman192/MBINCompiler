namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA93FE2A4CC8CA8A, NameHash = 0xE70B813560D9BFCE)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0x1A
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
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
