using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1AD0, GUID = 0x7E25C7AEC48DD019, NameHash = 0xB5B196A1179FFE00)]
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
        /* 0x0BF8 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        /* 0x1228 */ public bool ForcePlayerWalk;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1229 */ public byte[] Padding1229;
        /* 0x1230 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        /* 0x1240 */ public List<GcDebugCamera> DebugCameraPaths;
        /* 0x1250 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        /* 0x1260 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x1270 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        /* 0x1280 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1290 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        /* 0x1990 */ public bool DebugDroneScanPlayer;
        /* 0x19A0 */ public Vector3f DebugDroneSpawn;
        /* 0x19B0 */ public Vector3f DebugDroneTarget;
        /* 0x19C0 */ public int DebugNumDrones;
        /* 0x19D0 */ public Vector3f DebugWalkerSpawn;
        /* 0x19E0 */ public Vector3f DebugWalkerTarget;
        /* 0x19F0 */ public Vector3f DebugFlybyTarget;
        /* 0x1A00 */ public Vector3f DebugFlybyDir;
        /* 0x1A10 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1A14 */ public byte[] Padding1A14;
        /* 0x1A18 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x1A28 */ public string DebugExperienceCamShake;
        /* 0x1A40 */ public Vector3f DebugShipSpawnPos;
        /* 0x1A50 */ public Vector3f DebugShipSpawnFacing;
        /* 0x1A60 */ public Vector3f DebugShipSpawnUp;
        [NMS(Size = 0x10)]
        /* 0x1A70 */ public string PulseEncounter;
        /* 0x1A80 */ public Vector3f SandwormSpawnPos;
        /* 0x1A90 */ public Vector3f DebugFrigateFlybySpawnPos;
        /* 0x1AA0 */ public float DebugFrigateFlybyRotation;
        /* 0x1AA4 */ public float DebugFrigateFlybyHeightOffset;
        [NMS(Size = 0x10)]
        /* 0x1AA8 */ public string NormandyReward;
        /* 0x1AB8 */ public float CameraSpinTime;
        /* 0x1ABC */ public float CameraSpinRevolutions;
        /* 0x1AC0 */ public float CameraSpinVerticalOffset;
        /* 0x1AC4 */ public float CameraSpinDistanceOffset;
        /* 0x1AC8 */ public TkCurveType CameraSpinEasing;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1ACC */ public byte[] EndPadding;
    }
}
