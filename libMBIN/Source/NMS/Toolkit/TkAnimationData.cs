using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B3F7ACFE888523E, NameHash = 0x3A0F3C26A4978A6F)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 AdditiveBaseAnim;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x10 Anim;
        [NMS(Index = 4)]
        /* 0x020 */ public List<NMSString0x40> ExtraStartNodes;
        [NMS(Index = 5)]
        /* 0x030 */ public TkAnimationGameData GameData;
        [NMS(Index = 14)]
        /* 0x038 */ public float ActionFrame;
        [NMS(Index = 13)]
        /* 0x03C */ public float ActionStartFrame;
        [NMS(Index = 15)]
        /* 0x040 */ public float AdditiveBaseFrame;
        // size: 0x4
        public enum AnimTypeEnum : uint {
            Loop,
            OneShot,
            Control,
            OneShotBlendable,
        }
        [NMS(Index = 16)]
        /* 0x044 */ public AnimTypeEnum AnimType;
        // size: 0x3
        public enum CreatureSizeEnum : uint {
            AllSizes,
            SmallOnly,
            LargeOnly,
        }
        [NMS(Index = 17)]
        /* 0x048 */ public CreatureSizeEnum CreatureSize;
        [NMS(Index = 11)]
        /* 0x04C */ public float Delay;
        [NMS(Index = 7)]
        /* 0x050 */ public int FrameEnd;
        [NMS(Index = 6)]
        /* 0x054 */ public int FrameStart;
        [NMS(Index = 10)]
        /* 0x058 */ public float OffsetMax;
        [NMS(Index = 9)]
        /* 0x05C */ public float OffsetMin;
        [NMS(Index = 8)]
        /* 0x060 */ public int Priority;
        [NMS(Index = 12)]
        /* 0x064 */ public float Speed;
        [NMS(Index = 2)]
        /* 0x068 */ public NMSString0x80 Filename;
        [NMS(Index = 3)]
        /* 0x0E8 */ public NMSString0x40 StartNode;
        [NMS(Index = 20)]
        /* 0x128 */ public bool Active;
        [NMS(Index = 18)]
        /* 0x129 */ public bool Additive;
        [NMS(Index = 21)]
        /* 0x12A */ public bool Has30HzFrames;
        [NMS(Index = 19)]
        /* 0x12B */ public bool Mirrored;
    }
}
