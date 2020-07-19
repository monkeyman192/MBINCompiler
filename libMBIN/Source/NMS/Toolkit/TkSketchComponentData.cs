using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0x21FC6FCBFC43C2A2, NameHash = 0xBE4097172440769E)]
    public class TkSketchComponentData : NMSTemplate
    {
        /* 0x00 */ public float GraphPosX;
        /* 0x04 */ public float GraphPosY;
        /* 0x08 */ public float GraphZoom;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<TkSketchNodeData> Nodes;
    }
}