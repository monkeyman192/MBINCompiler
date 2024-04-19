namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44CC0793E9653419, NameHash = 0xBF03A94511E0F7B0)]
    public class GcSmokeBotStats : NMSTemplate
    {
        /* 0x00 */ public Vector3f MinCpuFPSFacing;
        /* 0x10 */ public Vector3f MinCpuFPSPos;
        /* 0x20 */ public Vector3f MinGpuFPSFacing;
        /* 0x30 */ public Vector3f MinGpuFPSPos;
        /* 0x40 */ public Vector3f MinMemoryFacing;
        /* 0x50 */ public Vector3f MinMemoryPos;
        /* 0x60 */ public float AvgCpuFPS;
        /* 0x64 */ public float AvgGpuFPS;
        /* 0x68 */ public int FrameCount;
        /* 0x6C */ public float MaxCpuFPS;
        /* 0x70 */ public float MaxGpuFPS;
        /* 0x74 */ public float MinCpuFPS;
        /* 0x78 */ public float MinGpuFPS;
        /* 0x7C */ public float MinMemory;
        /* 0x80 */ public float TotalCpuFps;
        /* 0x84 */ public float TotalGpuFps;
    }
}
