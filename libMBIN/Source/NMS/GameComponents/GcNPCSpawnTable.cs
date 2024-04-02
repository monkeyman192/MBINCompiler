using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AAB6600816BDADF, NameHash = 0xEF1AB4FE11FCFA6D)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        /* 0x480 */ public NMSString0x80 NPCMannequinModelName;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x500 */ public float[] NPCRaceScale;
        /* 0x528 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x538 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
