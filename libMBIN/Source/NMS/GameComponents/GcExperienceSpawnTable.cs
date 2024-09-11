using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D0071FCC0940C8B, NameHash = 0xD4ED2AD7)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public GcAIShipSpawnData BattleReinforcingPirateFrigateSpawn;
        [NMS(Index = 27, Size = 0x8, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x160 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        [NMS(Index = 26, Size = 0x6)]
        /* 0x2E0 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        [NMS(Index = 24)]
        /* 0x400 */ public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns;
        [NMS(Index = 29)]
        /* 0x440 */ public GcSentinelWaveGroup SummonerSpawns;
        [NMS(Index = 13)]
        /* 0x460 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        [NMS(Index = 10)]
        /* 0x470 */ public List<GcAIShipSpawnData> AmbientSpawns;
        [NMS(Index = 21)]
        /* 0x480 */ public List<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters;
        [NMS(Index = 15)]
        /* 0x490 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        [NMS(Index = 14)]
        /* 0x4A0 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        [NMS(Index = 12)]
        /* 0x4B0 */ public List<GcAIShipSpawnData> BattlePirateSpawns;
        [NMS(Index = 17)]
        /* 0x4C0 */ public List<GcAIShipSpawnData> BattleRecurringPirateSpawns;
        [NMS(Index = 16)]
        /* 0x4D0 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        [NMS(Index = 11)]
        /* 0x4E0 */ public List<GcAIShipSpawnData> BattleSpawns;
        [NMS(Index = 23)]
        /* 0x4F0 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        [NMS(Index = 22)]
        /* 0x500 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        [NMS(Index = 28)]
        /* 0x510 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        [NMS(Index = 0)]
        /* 0x520 */ public List<GcAIShipSpawnData> FlybySpawns;
        [NMS(Index = 25)]
        /* 0x530 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        [NMS(Index = 3)]
        /* 0x540 */ public List<GcAIShipSpawnData> MiningFlybySpawns;
        [NMS(Index = 1)]
        /* 0x550 */ public List<GcAIShipSpawnData> OutpostSpawns;
        [NMS(Index = 7)]
        /* 0x560 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        [NMS(Index = 19)]
        /* 0x570 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        [NMS(Index = 4)]
        /* 0x580 */ public List<GcAIShipSpawnData> PirateSpawns;
        [NMS(Index = 5)]
        /* 0x590 */ public List<GcAIShipSpawnData> PlanetaryPirateFlybySpawns;
        [NMS(Index = 6)]
        /* 0x5A0 */ public List<GcAIShipSpawnData> PlanetaryPirateRaidSpawns;
        [NMS(Index = 8)]
        /* 0x5B0 */ public List<GcPoliceSpawnWaveData> PoliceSpawns;
        [NMS(Index = 20)]
        /* 0x5C0 */ public List<GcPulseEncounterInfo> PulseEncounters;
        [NMS(Index = 30)]
        /* 0x5D0 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        [NMS(Index = 31)]
        /* 0x5E0 */ public List<GcSentinelSpawnWave> SentinelSpawns;
        [NMS(Index = 2)]
        /* 0x5F0 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        [NMS(Index = 9)]
        /* 0x600 */ public List<GcAIShipSpawnData> TraderSpawns;
    }
}
