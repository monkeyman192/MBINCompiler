using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EB2D9ED0276D2A8, NameHash = 0xD12E966E50238278)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        public List<GcBaseBuildingPartNavData> Parts;
    }
}
