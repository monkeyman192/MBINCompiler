using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D9203BD9828AB1E, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x0000 */ public bool Active;
        /* 0x0001 */ public bool DebugDraw;
        /* 0x0002 */ public bool AutoSave;
        /* 0x0008 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x0018 */ public bool FlyCamSmooth;
        /* 0x001C */ public float FlyCamSmoothFactor;
        /* 0x0020 */ public float FlyCamSpeedModifier;
        /* 0x0024 */ public float NPCIdleMinDelay;
        /* 0x0028 */ public float NPCIdleMaxDelay;
        /* 0x0030 */ public List<NMSString0x10> DefaultNPCIdles;
        /* 0x0040 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x0050 */ public bool LoadPetsFromDebugScene;
        /* 0x0051 */ public bool UpdatePetMoods;
        /* 0x0052 */ public bool ResetMoodsOnSummon;
        /* 0x0053 */ public bool ShowAccessoryMoods;
        /* 0x0054 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Size = 0x12)]
        /* 0x0058 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x2698 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        /* 0x3928 */ public bool ForcePlayerWalk;
        /* 0x392C */ public float PlayerWalkSpeed;
        /* 0x3930 */ public int PetRideIndex;
        /* 0x3938 */ public List<Vector3f> PetRideWayPoints;
        /* 0x3948 */ public bool ForceSunPosition;
        /* 0x3950 */ public Vector3f ForcedSunPosition;
        /* 0x3960 */ public bool ControlClouds;
        /* 0x3964 */ public float CloudCover;
        /* 0x3968 */ public float CloudAnimScale;
        /* 0x396C */ public Vector2f CloudWindOffset;
        /* 0x3974 */ public Vector2f CloudStratosphereWindOffset;
        /* 0x397C */ public bool BusyShips;
        /* 0x3980 */ public float CustomShipDockedTime;
        /* 0x3984 */ public float ShipSpawningMultiplier;
        /* 0x3988 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x3998 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x39A8 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x39B8 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x39C8 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x39D8 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x39E8 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x40E8 */ public bool DebugDroneScanPlayer;
        /* 0x40F0 */ public Vector3f DebugDroneSpawn;
        /* 0x4100 */ public Vector3f DebugDroneTarget;
        /* 0x4110 */ public int DebugNumDrones;
        /* 0x4120 */ public Vector3f DebugWalkerSpawn;
        /* 0x4130 */ public Vector3f DebugWalkerTarget;
        /* 0x4140 */ public Vector3f DebugFlybyTarget;
        /* 0x4150 */ public Vector3f DebugFlybyDir;
        /* 0x4160 */ public float DebugFlybyRange;
        /* 0x4168 */ public GcSeed DebugFlybySeed;
        /* 0x4178 */ public NMSString0x10 DebugExperienceCamShake;
        /* 0x4190 */ public Vector3f DebugShipSpawnPos;
        /* 0x41A0 */ public Vector3f DebugShipSpawnFacing;
        /* 0x41B0 */ public Vector3f DebugShipSpawnUp;
        /* 0x41C0 */ public NMSString0x10 PulseEncounter;
        /* 0x41D0 */ public NMSString0x10 BackgroundSpaceEncounter;
        /* 0x41E0 */ public Vector3f SandwormSpawnPos;
        /* 0x41F0 */ public Vector3f DebugFrigateFlybySpawnPos;
        /* 0x4200 */ public float DebugFrigateFlybyRotation;
        /* 0x4204 */ public float DebugFrigateFlybyHeightOffset;
        /* 0x4208 */ public NMSString0x10 NormandyReward;
        /* 0x4218 */ public NMSString0x10 LivingFrigateReward;
        /* 0x4228 */ public float CameraSpinTime;
        /* 0x422C */ public float CameraSpinRevolutions;
        /* 0x4230 */ public float CameraSpinVerticalOffset;
        /* 0x4234 */ public float CameraSpinDistanceOffset;
        /* 0x4238 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0x6)]
        /* 0x4240 */ public GcDebugPlanetPos[] PlanetPositions;
    }
}
