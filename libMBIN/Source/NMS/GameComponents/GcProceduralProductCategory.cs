using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xF3392D85BFB4732, NameHash = 0xE70B813560D9BFCE)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0x17
		public enum ProceduralProductCategoryEnum {
            Loot, Document, BioSample, Fossil, Plant, Tool, Farm, SeaLoot, SeaHorror, Salvage,
            Bones, SpaceHorror, SpaceBones, FreighterPassword, FreighterCaptLog, FreighterCrewList, FreighterTechHyp, FreighterTechSpeed, FreighterTechFuel, FreighterTechTrade,
            FreighterTechCombat, FreighterTechMine, FreighterTechExp
        }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}