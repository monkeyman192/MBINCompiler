using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2608B5B9ED8DC24B, NameHash = 0xBF03A94511E0F7B0)]
    public class GcSmokeBotStats : NMSTemplate
    {
        /* 0x00 */ public float AvgCpuFPS;
        /* 0x04 */ public float MinCpuFPS;
        /* 0x08 */ public float MaxCpuFPS;
        /* 0x10 */ public Vector3f MinCpuFPSPos;
        /* 0x20 */ public Vector3f MinCpuFPSFacing;
        /* 0x30 */ public float AvgGpuFPS;
        /* 0x34 */ public float MinGpuFPS;
        /* 0x38 */ public float MaxGpuFPS;
        /* 0x40 */ public Vector3f MinGpuFPSPos;
        /* 0x50 */ public Vector3f MinGpuFPSFacing;
        /* 0x60 */ public float MinMemory;
        /* 0x70 */ public Vector3f MinMemoryPos;
        /* 0x80 */ public Vector3f MinMemoryFacing;
        /* 0x90 */ public float TotalCpuFps;
        /* 0x94 */ public float TotalGpuFps;
        /* 0x98 */ public int FrameCount;
    }
}
