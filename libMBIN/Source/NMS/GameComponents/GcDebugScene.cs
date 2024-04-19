using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB700B271743BCB38, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        [NMS(Size = 0x6)]
        /* 0x0000 */ public GcDebugPlanetPos[] PlanetPositions;
        /* 0x00C0 */ public Vector3f DebugDroneSpawn;
        /* 0x00D0 */ public Vector3f DebugDroneTarget;
        /* 0x00E0 */ public Vector3f DebugFlybyDir;
        /* 0x00F0 */ public Vector3f DebugFlybyTarget;
        /* 0x0100 */ public Vector3f DebugFrigateFlybySpawnPos;
        /* 0x0110 */ public Vector3f DebugShipSpawnFacing;
        /* 0x0120 */ public Vector3f DebugShipSpawnPos;
        /* 0x0130 */ public Vector3f DebugShipSpawnUp;
        /* 0x0140 */ public Vector3f DebugSpaceBattleSpawnPosOffset;
        /* 0x0150 */ public Vector3f DebugSpaceBattleSpawnRotOffset;
        /* 0x0160 */ public Vector3f DebugWalkerSpawn;
        /* 0x0170 */ public Vector3f DebugWalkerTarget;
        /* 0x0180 */ public Vector3f ForcedSunPosition;
        /* 0x0190 */ public Vector3f SandwormSpawnPos;
        [NMS(Size = 0x12)]
        /* 0x01A0 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x2630 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x38C0 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x3F50 */ public NMSString0x10 BackgroundSpaceEncounter;
        /* 0x3F60 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x3F70 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x3F80 */ public List<GcDebugObjectDecoration> DebugDecorations;
        /* 0x3F90 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x3FA0 */ public NMSString0x10 DebugExperienceCamShake;
        /* 0x3FB0 */ public GcSeed DebugFlybySeed;
        /* 0x3FC0 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x3FD0 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x3FE0 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x3FF0 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        /* 0x4000 */ public List<NMSString0x10> DefaultNPCIdles;
        /* 0x4010 */ public NMSString0x10 LivingFrigateReward;
        /* 0x4020 */ public NMSString0x10 NormandyReward;
        /* 0x4030 */ public List<Vector3f> PetRideWayPoints;
        /* 0x4040 */ public NMSString0x10 PulseEncounter;
        /* 0x4050 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x4060 */ public Vector2f CloudStratosphereWindOffset;
        /* 0x4068 */ public Vector2f CloudWindOffset;
        /* 0x4070 */ public float CameraSpinDistanceOffset;
        /* 0x4074 */ public float CameraSpinRevolutions;
        /* 0x4078 */ public float CameraSpinTime;
        /* 0x407C */ public float CameraSpinVerticalOffset;
        /* 0x4080 */ public float CloudAnimScale;
        /* 0x4084 */ public float CloudCover;
        /* 0x4088 */ public float CustomShipDockedTime;
        /* 0x408C */ public GcSentinelTypes DebugDroneType;
        /* 0x4090 */ public float DebugFlybyRange;
        /* 0x4094 */ public float DebugFrigateFlybyHeightOffset;
        /* 0x4098 */ public float DebugFrigateFlybyRotation;
        /* 0x409C */ public int DebugNumDrones;
        /* 0x40A0 */ public float FlyCamSmoothFactor;
        /* 0x40A4 */ public float FlyCamSpeedModifier;
        /* 0x40A8 */ public float NPCIdleMaxDelay;
        /* 0x40AC */ public float NPCIdleMinDelay;
        /* 0x40B0 */ public GcPetBehaviours PetForceBehaviour;
        /* 0x40B4 */ public int PetRideIndex;
        /* 0x40B8 */ public float PlayerWalkSpeed;
        /* 0x40BC */ public float ShipSpawningMultiplier;
        /* 0x40C0 */ public bool Active;
        /* 0x40C1 */ public bool AutoCreateDecorations;
        /* 0x40C2 */ public bool AutoSave;
        /* 0x40C3 */ public bool BusyShips;
        /* 0x40C4 */ public TkCurveType CameraSpinEasing;
        /* 0x40C5 */ public bool ControlClouds;
        /* 0x40C6 */ public bool DebugDraw;
        /* 0x40C7 */ public bool DebugDroneScanPlayer;
        /* 0x40C8 */ public bool FlyCamSmooth;
        /* 0x40C9 */ public bool ForcePlayerWalk;
        /* 0x40CA */ public bool ForceSunPosition;
        /* 0x40CB */ public bool LoadPetsFromDebugScene;
        /* 0x40CC */ public bool PulseEncountersAlwaysPersist;
        /* 0x40CD */ public bool ResetMoodsOnSummon;
        /* 0x40CE */ public bool ShowAccessoryMoods;
        /* 0x40CF */ public bool UpdatePetMoods;
    }
}
