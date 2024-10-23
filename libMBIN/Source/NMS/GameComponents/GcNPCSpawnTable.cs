using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAB9CBE101FF0FCE, NameHash = 0x94CC6B42)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00 */ public VariableSizeString[] NPCModelNames;
        [NMS(Index = 1)]
        /* 0x90 */ public VariableSizeString NPCMannequinModelName;
        [NMS(Index = 4)]
        /* 0xA0 */ public List<GcNPCPlacementInfo> PlacementInfos;
        [NMS(Index = 3)]
        /* 0xB0 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        [NMS(Index = 2, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0xC0 */ public float[] NPCRaceScale;
    }
}
