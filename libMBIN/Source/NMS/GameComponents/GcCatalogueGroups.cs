using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD26DF9A0D47D6468, NameHash = 0x9A93F045019746C1)]
    public class GcCatalogueGroups : NMSTemplate
    {
        public enum CatalogueGroupEnum { MaterialsAndItems, CraftingAndTechnology, Buildables }
        public CatalogueGroupEnum CatalogueGroup;
    }
}
