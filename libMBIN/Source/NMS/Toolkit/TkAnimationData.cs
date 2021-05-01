using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x138, GUID = 0x43E75A538B7E1D0E, NameHash = 0x3A0F3C26A4978A6F)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Anim;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Filename;
        public enum AnimTypeEnum { Loop, OneShot, Control }
        /* 0x090 */ public AnimTypeEnum AnimType;
        /* 0x094 */ public int FrameStart;
        /* 0x098 */ public int FrameEnd;
        [NMS(Size = 0x40)]
        /* 0x09C */ public string StartNode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0DC */ public byte[] PaddingDC;
        /* 0x0E0 */ public List<NMSString0x40> ExtraStartNodes;
        /* 0x0F0 */ public int Priority;
        /* 0x0F4 */ public float OffsetMin;
        /* 0x0F8 */ public float OffsetMax;
        /* 0x0FC */ public float Delay;
        /* 0x100 */ public float Speed;
        /* 0x104 */ public float ActionStartFrame;
        /* 0x108 */ public float ActionFrame;
        public enum CreatureSizeEnum { AllSizes, SmallOnly, LargeOnly }
        /* 0x10C */ public CreatureSizeEnum CreatureSize;
        /* 0x110 */ public bool Additive;
        /* 0x111 */ public bool Mirrored;
        /* 0x112 */ public bool Active;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x113 */ public byte[] Padding113;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string AdditiveBaseAnim;
        /* 0x128 */ public float AdditiveBaseFrame;
        /* 0x12C */ public TkAnimationGameData GameData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x134 */ public byte[] EndPadding;
    }
}
