using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA58EABD3E554BF3, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        /* 0x00 */ public List<GcFiendCrimeSpawnData> Spawns;
        /* 0x10 */ public GcFiendCrime Crime;
        /* 0x14 */ public float ResponseRate;
    }
}
