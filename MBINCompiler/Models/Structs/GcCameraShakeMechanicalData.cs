namespace MBINCompiler.Models.Structs
{
    public class GcCameraShakeMechanicalData : NMSTemplate // 0x70
    {
        /* 0x000 */ public bool Active;

        [NMS(Size = 0xF, Ignore = true)]
        /* 0x010 */ public byte[] Padding1;

        /* 0x020 */ public Vector4f ShakeStrength;
        /* 0x030 */ public Vector4f ShakeFrequency;
        /* 0x040 */ public Vector4f ExtraShakeFrequency;
        /* 0x050 */ public Vector4f VibrateStrength;
        /* 0x060 */ public Vector4f VibrateFrequency;
        /* 0x070 */ public Vector4f ExtraVibrateFrequency;
    }
}
