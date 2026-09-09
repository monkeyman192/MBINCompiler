namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7EC0B1F7DE9CF3E, NameHash = 0xAE059184)]
    public class GcAtlasAllianceStats : NMSTemplate
    {
        // size: 0x4
        public enum AnimalsEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 0)]
        /* 0x00 */ public AnimalsEnum Animals;
        // size: 0x4
        public enum MineralsEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 1)]
        /* 0x04 */ public MineralsEnum Minerals;
        // size: 0x4
        public enum PlantsEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 4)]
        /* 0x08 */ public PlantsEnum Plants;
        // size: 0x4
        public enum StationsEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 3)]
        /* 0x0C */ public StationsEnum Stations;
        // size: 0x4
        public enum SystemsEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public SystemsEnum Systems;
    }
}
