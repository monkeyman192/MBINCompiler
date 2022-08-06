using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1D95CBD03BFA089D, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        public GcFiendCrime Crime;
        public float ResponseRate;
        public List<GcFiendCrimeSpawnData> Spawns;
    }
}
