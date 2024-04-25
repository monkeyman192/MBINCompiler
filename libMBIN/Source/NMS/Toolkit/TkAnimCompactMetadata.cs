using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4BFF64F3341B71C2, NameHash = 0x8D1F8DB67274D95A)]
    public class TkAnimCompactMetadata : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkAnimNodeFrameHalfData StillFrameData;
        [NMS(Index = 1)]
        /* 0x30 */ public List<TkAnimNodeFrameHalfData> AnimFrameData;
        [NMS(Index = 0)]
        /* 0x40 */ public List<TkAnimNodeData> NodeData;
        [NMS(Index = 3)]
        /* 0x50 */ public int FrameCount;
        [NMS(Index = 4)]
        /* 0x54 */ public int NodeCount;
        [NMS(Index = 5)]
        /* 0x58 */ public bool Has30HzFrames;
    }
}
