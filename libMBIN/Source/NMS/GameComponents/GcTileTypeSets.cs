using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CC2A36E9EB7990E, NameHash = 0xF99FFC7B95E84D7D)]
    public class GcTileTypeSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTileTypeSet> TileTypeSets;
    }
}
