using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseUberData : NMSTemplate // 0x28 bytes
    {
        public int Octaves;
        public float SharpToRoundFeatures;
        public float AmplifyFeatures;
        public float PerturbFeatures;
        public float AltitudeErosion;
        public float RidgeErosion;
        public float SlopeErosion;
        public float Lacunarity;
        public float Gain;
        public int DebugNoiseType;
        public string[] DebugNoiseTypeValues()
        {
            return new[] { "Plane", "Check", "Sine", "Uber" };
        }
    }
}
