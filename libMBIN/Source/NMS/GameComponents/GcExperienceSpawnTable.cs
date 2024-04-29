using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2BB1D140120284F, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public GcAIShipSpawnData BattleReinforcingPirateFrigateSpawn;
        [NMS(Index = 27, Size = 0x8, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x1C0 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        [NMS(Index = 26, Size = 0x6)]
        /* 0x340 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        [NMS(Index = 24)]
        /* 0x460 */ public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns;
        [NMS(Index = 29)]
        /* 0x4A0 */ public GcSentinelWaveGroup SummonerSpawns;
        [NMS(Index = 13)]
        /* 0x4C0 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        [NMS(Index = 10)]
        /* 0x4D0 */ public List<GcAIShipSpawnData> AmbientSpawns;
        [NMS(Index = 21)]
        /* 0x4E0 */ public List<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters;
        [NMS(Index = 15)]
        /* 0x4F0 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        [NMS(Index = 14)]
        /* 0x500 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        [NMS(Index = 12)]
        /* 0x510 */ public List<GcAIShipSpawnData> BattlePirateSpawns;
        [NMS(Index = 17)]
        /* 0x520 */ public List<GcAIShipSpawnData> BattleRecurringPirateSpawns;
        [NMS(Index = 16)]
        /* 0x530 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        [NMS(Index = 11)]
        /* 0x540 */ public List<GcAIShipSpawnData> BattleSpawns;
        [NMS(Index = 23)]
        /* 0x550 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        [NMS(Index = 22)]
        /* 0x560 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        [NMS(Index = 28)]
        /* 0x570 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        [NMS(Index = 0)]
        /* 0x580 */ public List<GcAIShipSpawnData> FlybySpawns;
        [NMS(Index = 25)]
        /* 0x590 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        [NMS(Index = 3)]
        /* 0x5A0 */ public List<GcAIShipSpawnData> MiningFlybySpawns;
        [NMS(Index = 1)]
        /* 0x5B0 */ public List<GcAIShipSpawnData> OutpostSpawns;
        [NMS(Index = 7)]
        /* 0x5C0 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        [NMS(Index = 19)]
        /* 0x5D0 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        [NMS(Index = 4)]
        /* 0x5E0 */ public List<GcAIShipSpawnData> PirateSpawns;
        [NMS(Index = 5)]
        /* 0x5F0 */ public List<GcAIShipSpawnData> PlanetaryPirateFlybySpawns;
        [NMS(Index = 6)]
        /* 0x600 */ public List<GcAIShipSpawnData> PlanetaryPirateRaidSpawns;
        [NMS(Index = 8)]
        /* 0x610 */ public List<GcPoliceSpawnWaveData> PoliceSpawns;
        [NMS(Index = 20)]
        /* 0x620 */ public List<GcPulseEncounterInfo> PulseEncounters;
        [NMS(Index = 30)]
        /* 0x630 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        [NMS(Index = 31)]
        /* 0x640 */ public List<GcSentinelSpawnWave> SentinelSpawns;
        [NMS(Index = 2)]
        /* 0x650 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        [NMS(Index = 9)]
        /* 0x660 */ public List<GcAIShipSpawnData> TraderSpawns;
    }
}
