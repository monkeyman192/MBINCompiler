namespace MBINCompiler.Models.Structs
{
    public class GcCameraShakeCapturedData : NMSTemplate // 0x14
    {
        /* 0x000 */ public bool Active;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;

        /* 0x004 */ public float ShakeStrength;
        /* 0x008 */ public float ShakeFrequency;
        /* 0x0C0 */ public float VibrateStrength;
        /* 0x010 */ public float VibrateFrequency;
    }
}
