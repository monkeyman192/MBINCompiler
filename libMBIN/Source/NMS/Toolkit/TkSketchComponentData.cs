using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE91336066F8AE79A, NameHash = 0xBE4097172440769E)]
    public class TkSketchComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkSketchNodeData> Nodes;
        /* 0x10 */ public float GraphPosX;
        /* 0x14 */ public float GraphPosY;
        /* 0x18 */ public float GraphZoom;
        /* 0x1C */ public float UpdateRateMultiplier;
    }
}
