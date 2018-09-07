using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x9C)]
    public class GcObjectDefinitionData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Filename;
		public enum ObjectRenderTypeEnum { Instanced, Single }
		public ObjectRenderTypeEnum ObjectRenderType;
        /* 0x84 */ public bool AutoCollision;
        /* 0x85 */ public bool MatchGroundColour;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding86;
		public enum SizeClassEnum { Tiny, Small, Medium, Large, Massive }
		public SizeClassEnum SizeClass;
		public enum ObjectCoverageTypeEnum { Blanket, Cluster, Solo }
		public ObjectCoverageTypeEnum ObjectCoverageType;
		public enum LifeTypeEnum { Rock, DryPlant, LargePlant, Artificial }
		public LifeTypeEnum LifeType;
		public enum LocationTypeEnum { AboveGround, UnderGround, WaterSurface, UnderWater }
		public LocationTypeEnum LocationType;
		public enum ObjectAlignmentEnum { Upright, SlightOffsetFromUpright, LargeOffsetFromUpright, ToNormal, SlightOffsetFromNormal, LargeOffsetFromNormal }
		public ObjectAlignmentEnum ObjectAlignment;

    }
}
