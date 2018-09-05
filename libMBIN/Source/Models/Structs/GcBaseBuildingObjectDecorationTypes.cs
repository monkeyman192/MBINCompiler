using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        public int BaseBuildingDecorationType;
        public string[] BaseBuildingDecorationTypeValues()
        {
            return new[] { "Normal", "SurfaceNormal", "Ceiling", "Terrain", "Substance", "Plant", "BuildingSurfaceNormal"};
        }
    }
}
