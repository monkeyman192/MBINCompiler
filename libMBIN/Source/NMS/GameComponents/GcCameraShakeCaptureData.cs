using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCameraShakeCaptureData : NMSTemplate // 0x14
    {
        public bool Active;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;

        public float ShakeStrength;
        public float ShakeFrequency;
        public float VibrateStrength;
        public float VibrateFrequency;
    }
}
