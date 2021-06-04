using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C10, GUID = 0x8B8FC105C70B3860, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x0000 */ public bool Active;
        /* 0x0001 */ public bool DebugDraw;
        /* 0x0002 */ public bool AutoSave;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x0003 */ public byte[] Padding3;
        /* 0x0008 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        /* 0x0018 */ public bool FlyCamSmooth;
        /* 0x001C */ public float FlyCamSmoothFactor;
        /* 0x0020 */ public float FlyCamSpeedModifier;
        /* 0x0024 */ public float NPCIdleMinDelay;
        /* 0x0028 */ public float NPCIdleMaxDelay;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x002C */ public byte[] Padding2C;
        /* 0x0030 */ public List<NMSString0x10> DefaultNPCIdles;
        /* 0x0040 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x0050 */ public bool LoadPetsFromDebugScene;
        /* 0x0051 */ public bool UpdatePetMoods;
        /* 0x0052 */ public bool ResetMoodsOnSummon;
        /* 0x0053 */ public bool ShowAccessoryMoods;
        /* 0x0054 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Size = 0x6)]
        /* 0x0058 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x0C28 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        /* 0x1258 */ public bool ForcePlayerWalk;
        /* 0x125C */ public int PetRideIndex;
        /* 0x1260 */ public List<Vector3f> PetRideWayPoints;
        /* 0x1270 */ public bool ForceSunPosition;
        /* 0x1280 */ public Vector3f ForcedSunPosition;
        /* 0x1290 */ public bool ControlClouds;
        /* 0x1294 */ public float CloudCover;
        /* 0x1298 */ public float CloudAnimScale;
        /* 0x129C */ public Vector2f CloudWindOffset;
        /* 0x12A4 */ public Vector2f CloudStratosphereWindOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12AC */ public byte[] Padding12AC;
        /* 0x12B0 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x12C0 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x12D0 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x12E0 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x12F0 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x1300 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1310 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x1A10 */ public bool DebugDroneScanPlayer;
        /* 0x1A20 */ public Vector3f DebugDroneSpawn;
        /* 0x1A30 */ public Vector3f DebugDroneTarget;
        /* 0x1A40 */ public int DebugNumDrones;
        /* 0x1A50 */ public Vector3f DebugWalkerSpawn;
        /* 0x1A60 */ public Vector3f DebugWalkerTarget;
        /* 0x1A70 */ public Vector3f DebugFlybyTarget;
        /* 0x1A80 */ public Vector3f DebugFlybyDir;
        /* 0x1A90 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1A94 */ public byte[] Padding1A94;
        /* 0x1A98 */ public GcSeed DebugFlybySeed;
        /* 0x1AA8 */ public NMSString0x10 DebugExperienceCamShake;
        /* 0x1AC0 */ public Vector3f DebugShipSpawnPos;
        /* 0x1AD0 */ public Vector3f DebugShipSpawnFacing;
        /* 0x1AE0 */ public Vector3f DebugShipSpawnUp;
        /* 0x1AF0 */ public NMSString0x10 PulseEncounter;
        /* 0x1B00 */ public Vector3f SandwormSpawnPos;
        /* 0x1B10 */ public Vector3f DebugFrigateFlybySpawnPos;
        /* 0x1B20 */ public float DebugFrigateFlybyRotation;
        /* 0x1B24 */ public float DebugFrigateFlybyHeightOffset;
        /* 0x1B28 */ public NMSString0x10 NormandyReward;
        /* 0x1B38 */ public float CameraSpinTime;
        /* 0x1B3C */ public float CameraSpinRevolutions;
        /* 0x1B40 */ public float CameraSpinVerticalOffset;
        /* 0x1B44 */ public float CameraSpinDistanceOffset;
        /* 0x1B48 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1B4C */ public byte[] Padding1B4C;
        [NMS(Size = 0x6)]
        /* 0x1B50 */ public GcDebugPlanetPos[] PlanetPositions;
    }
}
