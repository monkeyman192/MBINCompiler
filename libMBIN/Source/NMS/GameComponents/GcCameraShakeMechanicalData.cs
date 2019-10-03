using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4C487B2085AD7C1F, NameHash = 0x40BF52C4D8757B1A)]
    public class GcCameraShakeMechanicalData : NMSTemplate // 0x70
    {
        /* 0x000 */ public bool Active;

        [NMS(Size = 0xF, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;

        /* 0x010 */ public Vector4f ShakeStrength;
        /* 0x020 */ public Vector4f ShakeFrequency;
        /* 0x030 */ public Vector4f ExtraShakeFrequency;
        /* 0x040 */ public Vector4f VibrateStrength;
        /* 0x050 */ public Vector4f VibrateFrequency;
        /* 0x060 */ public Vector4f ExtraVibrateFrequency;
    }
}
