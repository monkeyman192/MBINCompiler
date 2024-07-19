using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE2ED7FED1D171506, NameHash = 0x6E59DA5E)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A Mask;
        [NMS(Index = 19)]
        /* 0x20 */ public List<TkAnimationAction> Actions;
        [NMS(Index = 10)]
        /* 0x30 */ public NMSString0x10 AdditiveBaseAnim;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Anim;
        [NMS(Index = 9)]
        /* 0x50 */ public List<NMSString0x40> ExtraStartNodes;
        [NMS(Index = 1)]
        /* 0x60 */ public VariableSizeString Filename;
        [NMS(Index = 25)]
        /* 0x70 */ public TkAnimationGameData GameData;
        [NMS(Index = 18)]
        /* 0x7C */ public float ActionFrame;
        [NMS(Index = 17)]
        /* 0x80 */ public float ActionStartFrame;
        [NMS(Index = 11)]
        /* 0x84 */ public float AdditiveBaseFrame;
        // size: 0x4
        public enum AnimTypeEnum : uint {
            Loop,
            OneShot,
            OneShotBlendable,
            Control,
        }
        [NMS(Index = 2)]
        /* 0x88 */ public AnimTypeEnum AnimType;
        // size: 0x3
        public enum CreatureSizeEnum : uint {
            AllSizes,
            SmallOnly,
            LargeOnly,
        }
        [NMS(Index = 20)]
        /* 0x8C */ public CreatureSizeEnum CreatureSize;
        [NMS(Index = 15)]
        /* 0x90 */ public float Delay;
        [NMS(Index = 6)]
        /* 0x94 */ public int FrameEnd;
        [NMS(Index = 7)]
        /* 0x98 */ public int FrameEndGame;
        [NMS(Index = 5)]
        /* 0x9C */ public int FrameStart;
        [NMS(Index = 14)]
        /* 0xA0 */ public float OffsetMax;
        [NMS(Index = 13)]
        /* 0xA4 */ public float OffsetMin;
        [NMS(Index = 4)]
        /* 0xA8 */ public int Priority;
        [NMS(Index = 16)]
        /* 0xAC */ public float Speed;
        [NMS(Index = 8)]
        /* 0xB0 */ public NMSString0x40 StartNode;
        [NMS(Index = 23)]
        /* 0xF0 */ public bool Active;
        [NMS(Index = 21)]
        /* 0xF1 */ public bool Additive;
        [NMS(Index = 3)]
        /* 0xF2 */ public bool AnimGroupOverride;
        [NMS(Index = 24)]
        /* 0xF3 */ public bool Has30HzFrames;
        [NMS(Index = 22)]
        /* 0xF4 */ public bool Mirrored;
    }
}
