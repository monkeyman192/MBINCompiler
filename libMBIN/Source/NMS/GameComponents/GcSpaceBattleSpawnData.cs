using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61283EA7B9AAF02C, NameHash = 0xC2E69AF7)]
    public class GcSpaceBattleSpawnData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0000 */ public GcAIShipSpawnData AlliedFlagshipSpawn;
        [NMS(Index = 4)]
        /* 0x0160 */ public GcAIShipSpawnData AlliedInitialSpawn;
        [NMS(Index = 8)]
        /* 0x02C0 */ public GcAIShipSpawnData HostileFlagshipSpawn;
        [NMS(Index = 24)]
        /* 0x0420 */ public GcAIShipSpawnData HostileFrigateReinforcementsSpawn;
        [NMS(Index = 15)]
        /* 0x0580 */ public GcAIShipSpawnData HostileInitialFlybySpawn;
        [NMS(Index = 16)]
        /* 0x06E0 */ public GcAIShipSpawnData HostileInitialSpawn;
        [NMS(Index = 21)]
        /* 0x0840 */ public GcAIShipSpawnData HostileRecurringSpawn;
        [NMS(Index = 13)]
        /* 0x09A0 */ public Vector3f HostileFlagshipOrientation;
        [NMS(Index = 27)]
        /* 0x09B0 */ public GcFlagshipBattleConfig FlagshipBattleConfig;
        [NMS(Index = 3)]
        /* 0x10F0 */ public NMSString0x20A AlliedFightersSquadName;
        [NMS(Index = 2)]
        /* 0x1110 */ public NMSString0x20A AlliedFlagshipSquadName;
        [NMS(Index = 26)]
        /* 0x1130 */ public GcSpaceBattlefieldSpawnData BattlefieldSpawn;
        [NMS(Index = 14)]
        /* 0x1150 */ public NMSString0x20A HostileFightersSquadName;
        [NMS(Index = 9)]
        /* 0x1170 */ public NMSString0x20A HostileFlagshipSquadName;
        [NMS(Index = 18)]
        /* 0x1190 */ public NMSString0x20A HostileInitialSpawnLocator;
        [NMS(Index = 23)]
        /* 0x11B0 */ public NMSString0x20A HostileRecurringSpawnLocator;
        [NMS(Index = 5)]
        /* 0x11D0 */ public Vector2f AlliedInitialSpawnCountRange;
        [NMS(Index = 17)]
        /* 0x11D8 */ public Vector2f HostileInitialSpawnCountRange;
        [NMS(Index = 29)]
        /* 0x11E0 */ public Vector2f SpawnAngle;
        [NMS(Index = 31)]
        /* 0x11E8 */ public Vector2f SpawnOffset;
        [NMS(Index = 30)]
        /* 0x11F0 */ public Vector2f SpawnPitch;
        [NMS(Index = 28)]
        /* 0x11F8 */ public Vector2f SpawnRange;
        [NMS(Index = 33)]
        /* 0x1200 */ public Vector2f SunAroundAngle;
        [NMS(Index = 32)]
        /* 0x1208 */ public Vector2f SunHeightAngle;
        [NMS(Index = 0)]
        /* 0x1210 */ public GcSpaceBattleFlagshipType AlliedFlagshipType;
        [NMS(Index = 6)]
        /* 0x1214 */ public GcRealityCommonFactions HostileFaction;
        [NMS(Index = 10)]
        /* 0x1218 */ public float HostileFlagshipOffsetDistance;
        [NMS(Index = 11)]
        /* 0x121C */ public float HostileFlagshipOffsetPitch;
        [NMS(Index = 12)]
        /* 0x1220 */ public float HostileFlagshipOffsetYaw;
        [NMS(Index = 7)]
        /* 0x1224 */ public GcSpaceBattleFlagshipType HostileFlagshipType;
        [NMS(Index = 25)]
        /* 0x1228 */ public int HostileFrigateCountForReinforce;
        [NMS(Index = 19)]
        /* 0x122C */ public float HostileInitialSpawnOffset;
        [NMS(Index = 20)]
        /* 0x1230 */ public float HostileInitialSpawnUpOffset;
        [NMS(Index = 22)]
        /* 0x1234 */ public float HostileRecurringSpawnTimer;
    }
}
