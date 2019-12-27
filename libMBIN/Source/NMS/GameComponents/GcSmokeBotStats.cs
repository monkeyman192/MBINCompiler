using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA0, GUID = 0x2608B5B9ED8DC24B, NameHash = 0xBF03A94511E0F7B0)]
    public class GcSmokeBotStats : NMSTemplate
    {
        /* 0x000 */ public float AvgCpuFPS;
        /* 0x004 */ public float MinCpuFPS;
        /* 0x008 */ public float MaxCpuFPS;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C */ public byte[] PaddingC;
        /* 0x010 */ public Vector3f MinCpuFPSPos;
        /* 0x020 */ public Vector3f MinCpuFPSFacing;
        /* 0x030 */ public float AvgGpuFPS;
        /* 0x034 */ public float MinGpuFPS;
        /* 0x038 */ public float MaxGpuFPS;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public Vector3f MinGpuFPSPos;
        /* 0x050 */ public Vector3f MinGpuFPSFacing;
        /* 0x060 */ public float MinMemory;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x064 */ public byte[] Padding64;
        /* 0x070 */ public Vector3f MinMemoryPos;
        /* 0x080 */ public Vector3f MinMemoryFacing;
        /* 0x090 */ public float TotalCpuFps;
        /* 0x094 */ public float TotalGpuFps;
		/* 0x098 */ public int FrameCount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x09C */ public byte[] EndPadding;
    }
}   