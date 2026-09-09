using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8DB47BE85AABC3F5, NameHash = 0x858CF362)]
    public class TkAnimComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkAnimationData Idle;
        [NMS(Index = 3)]
        /* 0x128 */ public NMSString0x10 AnimGroup;
        [NMS(Index = 5)]
        /* 0x138 */ public List<GcFilename> AnimLibraries;
        [NMS(Index = 4)]
        /* 0x148 */ public List<TkAnimationData> Anims;
        [NMS(Index = 7)]
        /* 0x158 */ public List<TkAnimJointLODData> JointLODOverrides;
        [NMS(Index = 8)]
        /* 0x168 */ public List<TkAnimLayerConfig> Layers;
        [NMS(Index = 2)]
        /* 0x178 */ public List<TkAnimRandomOneShots> RandomOneShots;
        [NMS(Index = 6)]
        /* 0x188 */ public List<TkAnimBlendTree> Trees;
        [NMS(Index = 0)]
        /* 0x198 */ public bool NetSyncAnimations;
    }
}
