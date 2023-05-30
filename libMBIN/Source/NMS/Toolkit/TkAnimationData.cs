using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimationData : NMSTemplate // 0xE0 bytes
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Anim;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Filename;

        /* 0x090 */ public int AnimType;
        public string[] AnimTypeValues()
        {
            return new[] { "Loop", "OneShot", "Control" };
        }

        /* 0x094 */ public int FrameStart;
        /* 0x098 */ public int FrameEnd;
        [NMS(Size = 4, Ignore = true)]
        /* 0x09C */ public byte[] Padding9C;

        [NMS(Size = 0x10)]
        /* 0x0A0 */ public string StartNode;
        /* 0x0B0 */ public List<NMSString0x10> ExtraStartNodes;

        /* 0x0C0 */ public int Priority;

        /* 0x0C4 */ public float LoopOffsetMin;
        /* 0x0C8 */ public float LoopOffsetMax;

        /* 0x0CC */ public float ControlDelay;
        /* 0x0D0 */ public float ControlSpeed;
        /* 0x0D4 */ public float ControlActionFrame;
        /* 0x0D8 */ public int ControlCreatureSize;
        public string[] ControlCreatureSizeValues()
        {
            return new[] { "AllSizes", "SmallOnly", "LargeOnly" };
        }

        /* 0x0DC */ public bool FlagsAdditive;
        /* 0x0DD */ public bool FlagsMirrored;
        /* 0x0DE */ public bool FlagsActive;

        [NMS(Size = 1, Ignore = true)]
        /* 0x0DF */ public byte[] PaddingDF;
    }
}
