using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67AF566F339BFA51, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        [NMS(Index = 72, Size = 0x6)]
        /* 0x0000 */ public GcDebugPlanetPos[] PlanetPositions;
        [NMS(Index = 43)]
        /* 0x00C0 */ public Vector3f DebugDroneSpawn;
        [NMS(Index = 44)]
        /* 0x00D0 */ public Vector3f DebugDroneTarget;
        [NMS(Index = 49)]
        /* 0x00E0 */ public Vector3f DebugFlybyDir;
        [NMS(Index = 48)]
        /* 0x00F0 */ public Vector3f DebugFlybyTarget;
        [NMS(Index = 60)]
        /* 0x0100 */ public Vector3f DebugFrigateFlybySpawnPos;
        [NMS(Index = 54)]
        /* 0x0110 */ public Vector3f DebugShipSpawnFacing;
        [NMS(Index = 53)]
        /* 0x0120 */ public Vector3f DebugShipSpawnPos;
        [NMS(Index = 55)]
        /* 0x0130 */ public Vector3f DebugShipSpawnUp;
        [NMS(Index = 61)]
        /* 0x0140 */ public Vector3f DebugSpaceBattleSpawnPosOffset;
        [NMS(Index = 62)]
        /* 0x0150 */ public Vector3f DebugSpaceBattleSpawnRotOffset;
        [NMS(Index = 46)]
        /* 0x0160 */ public Vector3f DebugWalkerSpawn;
        [NMS(Index = 47)]
        /* 0x0170 */ public Vector3f DebugWalkerTarget;
        [NMS(Index = 24)]
        /* 0x0180 */ public Vector3f ForcedSunPosition;
        [NMS(Index = 59)]
        /* 0x0190 */ public Vector3f SandwormSpawnPos;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x01A0 */ public GcPetData[] Pets;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x2630 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 40, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x38C0 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        [NMS(Index = 57)]
        /* 0x3F50 */ public NMSString0x10 BackgroundSpaceEncounter;
        [NMS(Index = 34)]
        /* 0x3F60 */ public List<GcDebugCamera> DebugCameraPaths;
        [NMS(Index = 36)]
        /* 0x3F70 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        [NMS(Index = 35)]
        /* 0x3F80 */ public List<GcDebugObjectDecoration> DebugDecorations;
        [NMS(Index = 38)]
        /* 0x3F90 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        [NMS(Index = 52)]
        /* 0x3FA0 */ public NMSString0x10 DebugExperienceCamShake;
        [NMS(Index = 51)]
        /* 0x3FB0 */ public GcSeed DebugFlybySeed;
        [NMS(Index = 37)]
        /* 0x3FC0 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        [NMS(Index = 11)]
        /* 0x3FD0 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        [NMS(Index = 33)]
        /* 0x3FE0 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        [NMS(Index = 39)]
        /* 0x3FF0 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Index = 10)]
        /* 0x4000 */ public List<NMSString0x10> DefaultNPCIdles;
        [NMS(Index = 66)]
        /* 0x4010 */ public NMSString0x10 LivingFrigateReward;
        [NMS(Index = 65)]
        /* 0x4020 */ public NMSString0x10 NormandyReward;
        [NMS(Index = 22)]
        /* 0x4030 */ public List<Vector3f> PetRideWayPoints;
        [NMS(Index = 56)]
        /* 0x4040 */ public NMSString0x10 PulseEncounter;
        [NMS(Index = 4)]
        /* 0x4050 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        [NMS(Index = 29)]
        /* 0x4060 */ public Vector2f CloudStratosphereWindOffset;
        [NMS(Index = 28)]
        /* 0x4068 */ public Vector2f CloudWindOffset;
        [NMS(Index = 70)]
        /* 0x4070 */ public float CameraSpinDistanceOffset;
        [NMS(Index = 68)]
        /* 0x4074 */ public float CameraSpinRevolutions;
        [NMS(Index = 67)]
        /* 0x4078 */ public float CameraSpinTime;
        [NMS(Index = 69)]
        /* 0x407C */ public float CameraSpinVerticalOffset;
        [NMS(Index = 27)]
        /* 0x4080 */ public float CloudAnimScale;
        [NMS(Index = 26)]
        /* 0x4084 */ public float CloudCover;
        [NMS(Index = 31)]
        /* 0x4088 */ public float CustomShipDockedTime;
        [NMS(Index = 42)]
        /* 0x408C */ public GcSentinelTypes DebugDroneType;
        [NMS(Index = 50)]
        /* 0x4090 */ public float DebugFlybyRange;
        [NMS(Index = 64)]
        /* 0x4094 */ public float DebugFrigateFlybyHeightOffset;
        [NMS(Index = 63)]
        /* 0x4098 */ public float DebugFrigateFlybyRotation;
        [NMS(Index = 45)]
        /* 0x409C */ public int DebugNumDrones;
        [NMS(Index = 6)]
        /* 0x40A0 */ public float FlyCamSmoothFactor;
        [NMS(Index = 7)]
        /* 0x40A4 */ public float FlyCamSpeedModifier;
        [NMS(Index = 9)]
        /* 0x40A8 */ public float NPCIdleMaxDelay;
        [NMS(Index = 8)]
        /* 0x40AC */ public float NPCIdleMinDelay;
        [NMS(Index = 16)]
        /* 0x40B0 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 21)]
        /* 0x40B4 */ public int PetRideIndex;
        [NMS(Index = 20)]
        /* 0x40B8 */ public float PlayerWalkSpeed;
        [NMS(Index = 32)]
        /* 0x40BC */ public float ShipSpawningMultiplier;
        [NMS(Index = 0)]
        /* 0x40C0 */ public bool Active;
        [NMS(Index = 3)]
        /* 0x40C1 */ public bool AutoCreateDecorations;
        [NMS(Index = 2)]
        /* 0x40C2 */ public bool AutoSave;
        [NMS(Index = 30)]
        /* 0x40C3 */ public bool BusyShips;
        [NMS(Index = 71)]
        /* 0x40C4 */ public TkCurveType CameraSpinEasing;
        [NMS(Index = 25)]
        /* 0x40C5 */ public bool ControlClouds;
        [NMS(Index = 1)]
        /* 0x40C6 */ public bool DebugDraw;
        [NMS(Index = 41)]
        /* 0x40C7 */ public bool DebugDroneScanPlayer;
        [NMS(Index = 5)]
        /* 0x40C8 */ public bool FlyCamSmooth;
        [NMS(Index = 19)]
        /* 0x40C9 */ public bool ForcePlayerWalk;
        [NMS(Index = 23)]
        /* 0x40CA */ public bool ForceSunPosition;
        [NMS(Index = 12)]
        /* 0x40CB */ public bool LoadPetsFromDebugScene;
        [NMS(Index = 58)]
        /* 0x40CC */ public bool PulseEncountersAlwaysPersist;
        [NMS(Index = 14)]
        /* 0x40CD */ public bool ResetMoodsOnSummon;
        [NMS(Index = 15)]
        /* 0x40CE */ public bool ShowAccessoryMoods;
        [NMS(Index = 13)]
        /* 0x40CF */ public bool UpdatePetMoods;
    }
}
