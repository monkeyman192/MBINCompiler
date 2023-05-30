using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCameraShakeMechanicalData : NMSTemplate // 0x70
    {
        public bool Active;

        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;

        public Vector4f ShakeStrength;
        public Vector4f ShakeFrequency;
        public Vector4f ExtraShakeFrequency;
        public Vector4f VibrateStrength;
        public Vector4f VibrateFrequency;
        public Vector4f ExtraVibrateFrequency;
    }
}
