using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCameraShakeData : NMSTemplate // 0xC0
    {
        public NMSString0x10 Name;

        public float TimeStart;
        public float TotalTime;
        public float DecayRate;
        public float StrengthSale;

        public GcCameraShakeCaptureData CapturedData; // 0x20

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding34; // offsetMechanicalData - (offsetCapturedData + szCapturedData)

        public GcCameraShakeMechanicalData MechanicalData; // 0x40

        public float FOVStrength;
        public float FOVFrequency;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] PaddingB8;
    }
}
