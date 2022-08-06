using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x51ED6DC102AE2ED8, NameHash = 0xE70B813560D9BFCE)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0x1A
		public enum ProceduralProductCategoryEnum {
            Loot, Document, BioSample, Fossil, Plant, Tool, Farm, SeaLoot, SeaHorror, Salvage,
            Bones, SpaceHorror, SpaceBones, FreighterPassword, FreighterCaptLog, FreighterCrewList, FreighterTechHyp, FreighterTechSpeed, FreighterTechFuel, FreighterTechTrade,
            FreighterTechCombat, FreighterTechMine, FreighterTechExp, DismantleBio, DismantleTech, DismantleData
        }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}