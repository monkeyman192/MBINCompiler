using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E522B820E17C6A5, NameHash = 0x56ACF1BE57EEA8E9)]
    public class GcBaseBuildingPartsDataTable : NMSTemplate
    {
        public List<GcBaseBuildingPartData> PartsData;
    }
}
