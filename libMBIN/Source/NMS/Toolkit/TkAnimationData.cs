using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B3F7ACFE888523E, NameHash = 0x3A0F3C26A4978A6F)]
    public class TkAnimationData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 AdditiveBaseAnim;
        /* 0x010 */ public NMSString0x10 Anim;
        /* 0x020 */ public List<NMSString0x40> ExtraStartNodes;
        /* 0x030 */ public TkAnimationGameData GameData;
        /* 0x038 */ public float ActionFrame;
        /* 0x03C */ public float ActionStartFrame;
        /* 0x040 */ public float AdditiveBaseFrame;
        // size: 0x4
        public enum AnimTypeEnum : uint {
            Loop,
            OneShot,
            Control,
            OneShotBlendable,
        }
        /* 0x044 */ public AnimTypeEnum AnimType;
        // size: 0x3
        public enum CreatureSizeEnum : uint {
            AllSizes,
            SmallOnly,
            LargeOnly,
        }
        /* 0x048 */ public CreatureSizeEnum CreatureSize;
        /* 0x04C */ public float Delay;
        /* 0x050 */ public int FrameEnd;
        /* 0x054 */ public int FrameStart;
        /* 0x058 */ public float OffsetMax;
        /* 0x05C */ public float OffsetMin;
        /* 0x060 */ public int Priority;
        /* 0x064 */ public float Speed;
        /* 0x068 */ public NMSString0x80 Filename;
        /* 0x0E8 */ public NMSString0x40 StartNode;
        /* 0x128 */ public bool Active;
        /* 0x129 */ public bool Additive;
        /* 0x12A */ public bool Has30HzFrames;
        /* 0x12B */ public bool Mirrored;
    }
}
