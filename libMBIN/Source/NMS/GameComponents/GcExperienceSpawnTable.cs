using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB95F193E5E573CDE, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        /* 0x000 */ public GcAIShipSpawnData BattleReinforcingPirateFrigateSpawn;
        [NMS(Size = 0x8, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x1C0 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        [NMS(Size = 0x6)]
        /* 0x340 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        /* 0x460 */ public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns;
        /* 0x4A0 */ public GcSentinelWaveGroup SummonerSpawns;
        /* 0x4C0 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        /* 0x4D0 */ public List<GcAIShipSpawnData> AmbientSpawns;
        /* 0x4E0 */ public List<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters;
        /* 0x4F0 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        /* 0x500 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        /* 0x510 */ public List<GcAIShipSpawnData> BattlePirateSpawns;
        /* 0x520 */ public List<GcAIShipSpawnData> BattleRecurringPirateSpawns;
        /* 0x530 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        /* 0x540 */ public List<GcAIShipSpawnData> BattleSpawns;
        /* 0x550 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        /* 0x560 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        /* 0x570 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        /* 0x580 */ public List<GcAIShipSpawnData> FlybySpawns;
        /* 0x590 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        /* 0x5A0 */ public List<GcAIShipSpawnData> MiningFlybySpawns;
        /* 0x5B0 */ public List<GcAIShipSpawnData> OutpostSpawns;
        /* 0x5C0 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        /* 0x5D0 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        /* 0x5E0 */ public List<GcAIShipSpawnData> PirateSpawns;
        /* 0x5F0 */ public List<GcAIShipSpawnData> PlanetaryPirateFlybySpawns;
        /* 0x600 */ public List<GcAIShipSpawnData> PlanetaryPirateRaidSpawns;
        /* 0x610 */ public List<GcPoliceSpawnWaveData> PoliceSpawns;
        /* 0x620 */ public List<GcPulseEncounterInfo> PulseEncounters;
        /* 0x630 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        /* 0x640 */ public List<GcSentinelSpawnWave> SentinelSpawns;
        /* 0x650 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        /* 0x660 */ public List<GcAIShipSpawnData> TraderSpawns;
    }
}
