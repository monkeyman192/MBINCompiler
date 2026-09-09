using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D24A017EC454151, NameHash = 0x55918A51)]
    public class GcTileTypeSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTileTypeSet> TileTypeSets;
    }
}
