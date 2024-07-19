namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8355BEB49D2AC574, NameHash = 0x9EA41A38)]
    public class GcObjectDefinitionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        // size: 0x4
        public enum LifeTypeEnum : uint {
            Rock,
            DryPlant,
            LushPlant,
            Artificial,
        }
        [NMS(Index = 6)]
        /* 0x10 */ public LifeTypeEnum LifeType;
        // size: 0x4
        public enum LocationTypeEnum : uint {
            AboveGround,
            UnderGround,
            WaterSurface,
            UnderWater,
        }
        [NMS(Index = 7)]
        /* 0x14 */ public LocationTypeEnum LocationType;
        // size: 0x6
        public enum ObjectAlignmentEnum : uint {
            Upright,
            SlightOffsetFromUpright,
            LargeOffsetFromUpright,
            ToNormal,
            SlightOffsetFromNormal,
            LargeOffsetFromNormal,
        }
        [NMS(Index = 8)]
        /* 0x18 */ public ObjectAlignmentEnum ObjectAlignment;
        // size: 0x3
        public enum ObjectCoverageTypeEnum : uint {
            Blanket,
            Cluster,
            Solo,
        }
        [NMS(Index = 5)]
        /* 0x1C */ public ObjectCoverageTypeEnum ObjectCoverageType;
        // size: 0x2
        public enum ObjectRenderTypeEnum : uint {
            Instanced,
            Single,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public ObjectRenderTypeEnum ObjectRenderType;
        // size: 0x5
        public enum SizeClassEnum : uint {
            Tiny,
            Small,
            Medium,
            Large,
            Massive,
        }
        [NMS(Index = 4)]
        /* 0x24 */ public SizeClassEnum SizeClass;
        [NMS(Index = 2)]
        /* 0x28 */ public bool AutoCollision;
        [NMS(Index = 3)]
        /* 0x29 */ public bool MatchGroundColour;
    }
}
