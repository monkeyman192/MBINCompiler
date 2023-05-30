using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetWaterData : NMSTemplate
    {
        public Colour WaterColourNear;
        public Colour WaterColourFar;
        public float WaterStrength;
        public float WaterColourStrength;
        public float WaterMultiplyStrength;
        public float WaterMultiplyMax;
        public float WaterRoughness;
        public float FresnelPower;
        public float FresnelMin;
        public float FresnelMax;
        public float Wave1Scale;
        public float Wave1Height;
        public float Wave1Speed;
        public float Wave2Scale;
        public float Wave2Height;
        public float Wave2Speed;
        public float NormalMap1Scale;
        public float NormalMap1Speed;
        public float NormalMap2Scale;
        public float NormalMap2Speed;
        public float FoamFadeHeight;
        public float Foam1Scale;
        public float Foam1Speed;
        public float Foam2Scale;
        public float Foam2Speed;
        public Colour FoamColour;
        public GcPlanetHeavyAirData HeavyAir;
    }
}
