using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA73648F89B6E0CCD, NameHash = 0x6E59DA5E)]
    public class TkAnimationData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x000 */ public NMSString0x20A Mask;
        [NMS(Index = 20)]
        /* 0x020 */ public List<TkAnimationAction> Actions;
        [NMS(Index = 13)]
        /* 0x030 */ public List<TkAnimationMask> AdditionalMasks;
        [NMS(Index = 10)]
        /* 0x040 */ public NMSString0x10 AdditiveBaseAnim;
        [NMS(Index = 0)]
        /* 0x050 */ public NMSString0x10 Anim;
        [NMS(Index = 9)]
        /* 0x060 */ public List<NMSString0x40> ExtraStartNodes;
        [NMS(Index = 1)]
        /* 0x070 */ public GcFilename Filename;
        [NMS(Index = 23)]
        /* 0x080 */ public List<TkAnimationLimbPlant> LimbPlants;
        [NMS(Index = 22)]
        /* 0x090 */ public List<TkAnimationNotify> Notifies;
        [NMS(Index = 28)]
        /* 0x0A0 */ public TkAnimationGameData GameData;
        [NMS(Index = 19)]
        /* 0x0AC */ public float ActionFrame;
        [NMS(Index = 18)]
        /* 0x0B0 */ public float ActionStartFrame;
        [NMS(Index = 11)]
        /* 0x0B4 */ public float AdditiveBaseFrame;
        // size: 0x4
        public enum AnimTypeEnum : uint {
            Loop,
            OneShot,
            OneShotBlendable,
            Control,
        }
        [NMS(Index = 2)]
        /* 0x0B8 */ public AnimTypeEnum AnimType;
        // size: 0x3
        public enum CreatureSizeEnum : uint {
            AllSizes,
            SmallOnly,
            LargeOnly,
        }
        [NMS(Index = 21)]
        /* 0x0BC */ public CreatureSizeEnum CreatureSize;
        [NMS(Index = 16)]
        /* 0x0C0 */ public float Delay;
        [NMS(Index = 6)]
        /* 0x0C4 */ public int FrameEnd;
        [NMS(Index = 7)]
        /* 0x0C8 */ public int FrameEndGame;
        [NMS(Index = 5)]
        /* 0x0CC */ public int FrameStart;
        [NMS(Index = 15)]
        /* 0x0D0 */ public float OffsetMax;
        [NMS(Index = 14)]
        /* 0x0D4 */ public float OffsetMin;
        [NMS(Index = 4)]
        /* 0x0D8 */ public int Priority;
        [NMS(Index = 17)]
        /* 0x0DC */ public float Speed;
        [NMS(Index = 8)]
        /* 0x0E0 */ public NMSString0x40 StartNode;
        [NMS(Index = 26)]
        /* 0x120 */ public bool Active;
        [NMS(Index = 24)]
        /* 0x121 */ public bool Additive;
        [NMS(Index = 3)]
        /* 0x122 */ public bool AnimGroupOverride;
        [NMS(Index = 27)]
        /* 0x123 */ public bool Has30HzFrames;
        [NMS(Index = 25)]
        /* 0x124 */ public bool Mirrored;
    }
}
