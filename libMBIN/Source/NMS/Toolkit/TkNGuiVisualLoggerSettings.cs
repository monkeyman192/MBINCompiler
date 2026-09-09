using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2DAA7F9A9C76181B, NameHash = 0x81F2F867)]
    public class TkNGuiVisualLoggerSettings : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public List<NMSString0x80> FilterCategories;
        [NMS(Index = 11)]
        /* 0x10 */ public List<NMSString0x80> FilterComponents;
        [NMS(Index = 14)]
        /* 0x20 */ public List<NMSString0x80> FilterJoints;
        [NMS(Index = 13)]
        /* 0x30 */ public List<NMSString0x80> FilterTracks;
        [NMS(Index = 10)]
        /* 0x40 */ public float AxisSize;
        [NMS(Index = 9)]
        /* 0x44 */ public int GraphHeight;
        [NMS(Index = 8)]
        /* 0x48 */ public float GraphOutlierThreshold;
        [NMS(Index = 6)]
        /* 0x4C */ public int OnionSkinCount;
        [NMS(Index = 1)]
        /* 0x50 */ public bool AutoTrackSelected;
        [NMS(Index = 5)]
        /* 0x51 */ public bool DrawAnnotations;
        [NMS(Index = 3)]
        /* 0x52 */ public bool DrawJoints;
        [NMS(Index = 4)]
        /* 0x53 */ public bool DrawLines;
        [NMS(Index = 2)]
        /* 0x54 */ public bool DrawTransforms;
        [NMS(Index = 15)]
        /* 0x55 */ public bool FilterInWorldJoints;
        [NMS(Index = 0)]
        /* 0x56 */ public bool Recording;
        [NMS(Index = 7)]
        /* 0x57 */ public bool TrimGraphsToOnionSkin;
    }
}
