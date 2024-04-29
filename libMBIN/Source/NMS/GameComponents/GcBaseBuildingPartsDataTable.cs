using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5E7D28878D47A00, NameHash = 0x56ACF1BE57EEA8E9)]
    public class GcBaseBuildingPartsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartData> PartsData;
    }
}
