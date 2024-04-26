namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF632B2B1C66A9F6A, NameHash = 0xA63D153E45037707)]
    public class GcModelExplosionRule : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f AxisMultiplier;
        [NMS(Index = 5)]
        /* 0x10 */ public Vector3f Offset;
        // size: 0x4
        public enum ExplodeActionEnum : uint {
            RelativeToParent,
            DontMove,
            SaveCenter,
            RelativeToSaved,
        }
        [NMS(Index = 3)]
        /* 0x20 */ public ExplodeActionEnum ExplodeAction;
        [NMS(Index = 6)]
        /* 0x24 */ public float ExplodeMod;
        // size: 0x2
        public enum MatchNameEnum : uint {
            ContainsString,
            ExactString,
        }
        [NMS(Index = 1)]
        /* 0x28 */ public MatchNameEnum MatchName;
        // size: 0x4
        public enum MatchNodeTypeEnum : uint {
            Any,
            Mesh,
            Model,
            Joint,
        }
        [NMS(Index = 0)]
        /* 0x2C */ public MatchNodeTypeEnum MatchNodeType;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x20 String;
    }
}
