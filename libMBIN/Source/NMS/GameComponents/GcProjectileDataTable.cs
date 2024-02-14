using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A300083029CA988, NameHash = 0x9439AD97E8673BC0)]
    public class GcProjectileDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcProjectileData> Table;
        /* 0x10 */ public List<GcLaserBeamData> Lasers;
    }
}
