using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF70B426BA3CD32EB, NameHash = 0x9439AD97E8673BC0)]
    public class GcProjectileDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcProjectileData> Table;
        /* 0x10 */ public List<GcLaserBeamData> Lasers;
    }
}
