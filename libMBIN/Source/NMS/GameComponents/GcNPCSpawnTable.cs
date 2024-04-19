using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AAB6600816BDADF, NameHash = 0xEF1AB4FE11FCFA6D)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        /* 0x000 */ public List<GcNPCPlacementInfo> PlacementInfos;
        /* 0x010 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x020 */ public float[] NPCRaceScale;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x044 */ public NMSString0x80[] NPCModelNames;
        /* 0x4C4 */ public NMSString0x80 NPCMannequinModelName;
    }
}
