using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA5790FF9AE6AF9EA, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        public GcFiendCrime Crime;
        public float ResponseRate;
        public List<GcFiendCrimeSpawnData> Spawns;
    }
}
