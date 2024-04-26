using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE91336066F8AE79A, NameHash = 0xBE4097172440769E)]
    public class TkSketchComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<TkSketchNodeData> Nodes;
        [NMS(Index = 0)]
        /* 0x10 */ public float GraphPosX;
        [NMS(Index = 1)]
        /* 0x14 */ public float GraphPosY;
        [NMS(Index = 2)]
        /* 0x18 */ public float GraphZoom;
        [NMS(Index = 3)]
        /* 0x1C */ public float UpdateRateMultiplier;
    }
}
