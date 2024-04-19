namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF632B2B1C66A9F6A, NameHash = 0xA63D153E45037707)]
    public class GcModelExplosionRule : NMSTemplate
    {
        /* 0x00 */ public Vector3f AxisMultiplier;
        /* 0x10 */ public Vector3f Offset;
        // size: 0x4
        public enum ExplodeActionEnum : uint {
            RelativeToParent,
            DontMove,
            SaveCenter,
            RelativeToSaved,
        }
        /* 0x20 */ public ExplodeActionEnum ExplodeAction;
        /* 0x24 */ public float ExplodeMod;
        // size: 0x2
        public enum MatchNameEnum : uint {
            ContainsString,
            ExactString,
        }
        /* 0x28 */ public MatchNameEnum MatchName;
        // size: 0x4
        public enum MatchNodeTypeEnum : uint {
            Any,
            Mesh,
            Model,
            Joint,
        }
        /* 0x2C */ public MatchNodeTypeEnum MatchNodeType;
        /* 0x30 */ public NMSString0x20 String;
    }
}
