using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0xE140355C837DFCBF, NameHash = 0xB5B196A1179FFE00)]
    public class GcDebugScene : NMSTemplate
    {
        /* 0x000 */ public bool Active;
        /* 0x001 */ public bool DebugDraw;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x002 */ public byte[] Padding2;
        /* 0x008 */ public List<GcExperienceDebugTriggerInput> KeyPress; //false reference to allow compilation
        /* 0x018 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        /* 0x028 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        /* 0x038 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        /* 0x048 */ public bool DebugExperienceRender;
        /* 0x049 */ public bool DebugDroneScanPlayer;
        /* 0x050 */ public Vector3f DebugDroneSpawn;
        /* 0x060 */ public Vector3f DebugDronTarget;
        /* 0x070 */ public int DebugNumDrones;
        /* 0x080 */ public Vector3f DebugWalkerSpawn;
        /* 0x090 */ public Vector3f DebugWalkerTarget;
        /* 0x0A0 */ public Vector3f DebugFlybyTarget;
        /* 0x0B0 */ public Vector3f DebugFlybyDir;
        /* 0x0C0 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C4 */ public byte[] PaddingC4;
        /* 0x0C8 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x0D8 */ public string DebugExperienceCamShake;
        /* 0x0F0 */ public Vector3f DebugShipSpawnPos;
        /* 0x100 */ public Vector3f DebugShipSpawnFacing;
        /* 0x110 */ public Vector3f DebugShipSpawnUp;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string PulseEncounter;
        /* 0x130 */ public Vector3f SandwormSpawnPos;
    }
}
