using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC99890EADE2FE6D3, NameHash = 0xF99FFC7B95E84D7D)]
    public class GcTileTypeSets : NMSTemplate
    {
        /* 0x0 */ public List<GcTileTypeSet> TileTypeSets;
    }
}
