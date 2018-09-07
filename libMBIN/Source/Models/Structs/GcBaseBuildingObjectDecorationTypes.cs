using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
		public enum BaseBuildingDecorationTypeEnum { Normal, SurfaceNormal, Ceiling, Terrain, Substance, Plant, BuildingSurfaceNormal }
		public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}
