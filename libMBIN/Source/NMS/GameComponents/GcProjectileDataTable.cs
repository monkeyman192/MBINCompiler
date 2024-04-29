using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A898CD3789A9EB0, NameHash = 0x9439AD97E8673BC0)]
    public class GcProjectileDataTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcLaserBeamData> Lasers;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcProjectileData> Table;
    }
}
