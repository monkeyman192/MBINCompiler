using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, Alignment = 0x10, GUID = 0xC410F85C9F55A883, NameHash = 0xA63D153E45037707)]
    public class GcModelExplosionRule : NMSTemplate
    {
        public enum MatchNodeTypeEnum { Any, Mesh, Model, Joint }
        /* 0x00 */ public MatchNodeTypeEnum GetMatchNodeType;
        public enum MatchNameEnum { ContainsString, ExactString }
        /* 0x04 */ public MatchNameEnum MatchName;
        /* 0x08 */ public NMSString0x20 String;
        public enum ExplodeActionEnum { RelativeToParent, DontMove, SaveCenter, RelativeToSaved }
        /* 0x28 */ public ExplodeActionEnum ExplodeAction;
        /* 0x30 */ public Vector3f AxisMultiplier;
        /* 0x40 */ public Vector3f Offset;
        /* 0x50 */ public float ExplodeMod;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x54 */ public byte[] EndPadding;
    }
}
