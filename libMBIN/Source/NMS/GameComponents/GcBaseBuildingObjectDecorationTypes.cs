using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x48FADD6F70304AF4, NameHash = 0xCBF38A24719D032E)]
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        public enum BaseBuildingDecorationTypeEnum { Normal, SurfaceNormal, Ceiling, Terrain, Substance, Plant, BuildingSurfaceNormal }
        public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}