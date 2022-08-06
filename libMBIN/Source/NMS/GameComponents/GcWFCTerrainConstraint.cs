using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86C95D0A39321796, NameHash = 0xF0679B25F5343B25)]
    public class GcWFCTerrainConstraint : NMSTemplate
    {
        public enum DirectionEnum { Left, Back, Right, Forward, LeftBack, RightBack, RightForward, LeftForward, All }
        /* 0x0 */ public DirectionEnum Direction;
        public enum LevelsEnum { Lower, Upper, Both }
        /* 0x0 */ public LevelsEnum Levels;
        public enum TerrainEnum { RequireAbove, RequireBelow }
        /* 0x0 */ public TerrainEnum Terrain;
    }
}
