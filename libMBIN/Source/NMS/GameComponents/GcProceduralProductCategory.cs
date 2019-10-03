using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF9F81B6AD39F86F3, NameHash = 0xE70B813560D9BFCE)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0xB
		public enum ProceduralProductCategoryEnum { Loot, Document, BioSample, Fossil, Plant, Tool, Farm, SeaLoot, SeaHorror, Salvage, Bones }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
