using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x138)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Anim;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Filename;

		public enum AnimTypeEnum { Loop, OneShot, Control }
		public AnimTypeEnum AnimType;

        /* 0x094 */ public int FrameStart;
        /* 0x098 */ public int FrameEnd;

        [NMS(Size = 0x40)]
        /* 0x09C */ public string StartNode;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0DC */ public byte[] PaddingDC;
        /* 0x0E0 */ public List<NMSString0x40> ExtraStartNodes;

        /* 0x0F0 */ public int Priority;
        /* 0x0F4 */ public float LoopOffsetMin;
        /* 0x0F8 */ public float LoopOffsetMax;

        /* 0x0FC */ public float Delay;
        /* 0x100 */ public float Speed;
        /* 0x104 */ public float ActionFrameStart;
        /* 0x108 */ public float ActionFrame;
		public enum ControlCreatureSizeEnum { AllSizes, SmallOnly, LargeOnly }
		public ControlCreatureSizeEnum ControlCreatureSize;

        /* 0x110 */ public bool Additive;
        /* 0x111 */ public bool Mirrored;
        /* 0x112 */ public bool Active;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x113 */ public byte[] Padding113;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string AdditiveBaseAnim;
        /* 0x128 */ public float AdditiveBaseFrame;
        /* 0x12C */ public TkAnimationGameData GameData;

        [NMS(Size = 4, Ignore = true)]
        /* 0x134 */ public byte[] EndPadding;
    }
}
