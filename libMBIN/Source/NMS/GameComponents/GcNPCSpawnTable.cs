using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C0, GUID = 0x9DE4BACE6CA69877)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        /* 0x380 */ public float[] NPCRaceScale;

        /* 0x3A0 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x3B0 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
