using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97D91948695B44BC, NameHash = 0xD4ED2AD7)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        [NMS(Index = 12, Size = 0x7, EnumType = typeof(GcSpaceBattleType.SpaceBattleTypeEnum))]
        /* 0x0000 */ public GcSpaceBattleSpawnData[] SpaceBattleSpawns;
        [NMS(Index = 22, Size = 0xA, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x7FC0 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        [NMS(Index = 21, Size = 0x6)]
        /* 0x81A0 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        [NMS(Index = 19)]
        /* 0x82C0 */ public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns;
        [NMS(Index = 24)]
        /* 0x8300 */ public GcSentinelWaveGroup SummonerSpawns;
        [NMS(Index = 11)]
        /* 0x8320 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        [NMS(Index = 10)]
        /* 0x8330 */ public List<GcAIShipSpawnData> AmbientSpawns;
        [NMS(Index = 16)]
        /* 0x8340 */ public List<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters;
        [NMS(Index = 18)]
        /* 0x8350 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        [NMS(Index = 17)]
        /* 0x8360 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        [NMS(Index = 23)]
        /* 0x8370 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        [NMS(Index = 0)]
        /* 0x8380 */ public List<GcAIShipSpawnData> FlybySpawns;
        [NMS(Index = 20)]
        /* 0x8390 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        [NMS(Index = 3)]
        /* 0x83A0 */ public List<GcAIShipSpawnData> MiningFlybySpawns;
        [NMS(Index = 1)]
        /* 0x83B0 */ public List<GcAIShipSpawnData> OutpostSpawns;
        [NMS(Index = 7)]
        /* 0x83C0 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        [NMS(Index = 13)]
        /* 0x83D0 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        [NMS(Index = 4)]
        /* 0x83E0 */ public List<GcAIShipSpawnData> PirateSpawns;
        [NMS(Index = 5)]
        /* 0x83F0 */ public List<GcAIShipSpawnData> PlanetaryPirateFlybySpawns;
        [NMS(Index = 6)]
        /* 0x8400 */ public List<GcAIShipSpawnData> PlanetaryPirateRaidSpawns;
        [NMS(Index = 8)]
        /* 0x8410 */ public List<GcPoliceSpawnWaveData> PoliceSpawns;
        [NMS(Index = 15)]
        /* 0x8420 */ public List<GcPulseEncounterInfo> PulseEncounters;
        [NMS(Index = 25)]
        /* 0x8430 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        [NMS(Index = 26)]
        /* 0x8440 */ public List<GcSentinelSpawnWave> SentinelSpawns;
        [NMS(Index = 2)]
        /* 0x8450 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        [NMS(Index = 14)]
        /* 0x8460 */ public List<GcAIShipSpawnData> SwarmDroneAttackSpawns;
        [NMS(Index = 9)]
        /* 0x8470 */ public List<GcAIShipSpawnData> TraderSpawns;
    }
}
