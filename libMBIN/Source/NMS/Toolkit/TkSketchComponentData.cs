using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x20, Alignment = 0x8, GUID = 0x229D20001EB4BC5A, NameHash = 0xBE4097172440769E)]
    public class TkSketchComponentData : NMSTemplate
    {
        /* 0x00 */ public float GraphPosX;
        /* 0x04 */ public float GraphPosY;
        /* 0x08 */ public float GraphZoom;
        /* 0x0C */ public float UpdateRateMultiplier;
        /* 0x10 */ public List<TkSketchNodeData> Nodes;
    }
}
