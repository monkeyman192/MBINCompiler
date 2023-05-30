using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSpawnDensity : NMSTemplate
    {
        public NMSString0x10 Name;
        public bool Active;
        public int CoverageType;
        public string[] CoverageTypeValues()
        {
            return new[] { "Total", "SmoothPatch" };
        }

        public float PatchSize;
        public float RegionScale;
    }
}
