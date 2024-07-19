namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C36A9A23412A38, NameHash = 0x2B1B33D2)]
    public class GcSmokeBotStats : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f MinCpuFPSFacing;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector3f MinCpuFPSPos;
        [NMS(Index = 9)]
        /* 0x20 */ public Vector3f MinGpuFPSFacing;
        [NMS(Index = 8)]
        /* 0x30 */ public Vector3f MinGpuFPSPos;
        [NMS(Index = 12)]
        /* 0x40 */ public Vector3f MinMemoryFacing;
        [NMS(Index = 11)]
        /* 0x50 */ public Vector3f MinMemoryPos;
        [NMS(Index = 0)]
        /* 0x60 */ public float AvgCpuFPS;
        [NMS(Index = 5)]
        /* 0x64 */ public float AvgGpuFPS;
        [NMS(Index = 15)]
        /* 0x68 */ public int FrameCount;
        [NMS(Index = 2)]
        /* 0x6C */ public float MaxCpuFPS;
        [NMS(Index = 7)]
        /* 0x70 */ public float MaxGpuFPS;
        [NMS(Index = 1)]
        /* 0x74 */ public float MinCpuFPS;
        [NMS(Index = 6)]
        /* 0x78 */ public float MinGpuFPS;
        [NMS(Index = 10)]
        /* 0x7C */ public float MinMemory;
        [NMS(Index = 13)]
        /* 0x80 */ public float TotalCpuFps;
        [NMS(Index = 14)]
        /* 0x84 */ public float TotalGpuFps;
    }
}
