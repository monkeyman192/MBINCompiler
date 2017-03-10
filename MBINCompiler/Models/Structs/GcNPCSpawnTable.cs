using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size=7,Ignore =false)]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 7, Ignore = false)]
        /* 0x380 */ public float[] NPCRaceScale;

        public List<GcUniqueNPCSpawnData> UniqueNPCs;
        public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
