using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BD4ACA62EBC2818, NameHash = 0x5CD4231F)]
    public class GcCutSceneData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x0000 */ public GcCutSceneClouds Clouds;
        [NMS(Index = 9)]
        /* 0x0060 */ public Vector3f ForcedSunDir;
        [NMS(Index = 11)]
        /* 0x0070 */ public TkVoxelGeneratorSettingsElement VoxelSettings;
        [NMS(Index = 6)]
        /* 0x2310 */ public List<GcCutSceneTriggerInputData> KeyPressActions;
        [NMS(Index = 5)]
        /* 0x2320 */ public List<GcCutSceneTriggerActionData> OnLoadActions;
        [NMS(Index = 7)]
        /* 0x2330 */ public List<GcCutSceneSpawnData> Spawns;
        [NMS(Index = 16)]
        /* 0x2340 */ public float FlyCamFoV;
        [NMS(Index = 14)]
        /* 0x2344 */ public float FlyCamSmoothFactor;
        [NMS(Index = 15)]
        /* 0x2348 */ public float FlyCamSpeedModifier;
        [NMS(Index = 4)]
        /* 0x234C */ public int GuidGenerator;
        [NMS(Index = 0)]
        /* 0x2350 */ public bool Active;
        [NMS(Index = 3)]
        /* 0x2351 */ public bool AutomaticObjectEditing;
        [NMS(Index = 2)]
        /* 0x2352 */ public bool AutoSave;
        [NMS(Index = 1)]
        /* 0x2353 */ public bool DebugDraw;
        [NMS(Index = 13)]
        /* 0x2354 */ public bool FlyCamSmooth;
        [NMS(Index = 8)]
        /* 0x2355 */ public bool ForceSunDir;
        [NMS(Index = 10)]
        /* 0x2356 */ public bool UseVoxelSettings;
    }
}
