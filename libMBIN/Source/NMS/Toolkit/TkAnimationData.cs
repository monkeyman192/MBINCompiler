using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x138, GUID = 0x43E75A538B7E1D0E)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Anim { get; set; }
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Filename { get; set; }

		public enum AnimTypeEnum { Loop, OneShot, Control }
		/* 0x090 */ public AnimTypeEnum AnimType { get; set; }

        /* 0x094 */ public int FrameStart { get; set; }
        /* 0x098 */ public int FrameEnd { get; set; }

        [NMS(Size = 0x40)]
        /* 0x09C */ public string StartNode { get; set; }
        [NMS(Size = 4, Ignore = true)]
        /* 0x0DC */ public byte[] PaddingDC { get; set; }
        /* 0x0E0 */ public List<NMSString0x40> ExtraStartNodes { get; set; }

        /* 0x0F0 */ public int Priority { get; set; }
        /* 0x0F4 */ public float LoopOffsetMin { get; set; }
        /* 0x0F8 */ public float LoopOffsetMax { get; set; }

        /* 0x0FC */ public float Delay { get; set; }
        /* 0x100 */ public float Speed { get; set; }
        /* 0x104 */ public float ActionFrameStart { get; set; }
        /* 0x108 */ public float ActionFrame { get; set; }
		public enum ControlCreatureSizeEnum { AllSizes, SmallOnly, LargeOnly }
		/* 0x10C */ public ControlCreatureSizeEnum ControlCreatureSize { get; set; }

        /* 0x110 */ public bool Additive { get; set; }
        /* 0x111 */ public bool Mirrored { get; set; }
        /* 0x112 */ public bool Active { get; set; }
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x113 */ public byte[] Padding113 { get; set; }
        [NMS(Size = 0x10)]
        /* 0x118 */ public string AdditiveBaseAnim { get; set; }
        /* 0x128 */ public float AdditiveBaseFrame { get; set; }
        /* 0x12C */ public TkAnimationGameData GameData { get; set; }

        [NMS(Size = 4, Ignore = true)]
        /* 0x134 */ public byte[] EndPadding { get; set; }
    }
}
