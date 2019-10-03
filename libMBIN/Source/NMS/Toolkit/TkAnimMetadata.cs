using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x58, GUID = 0x3CD7D2192958BA6C, NameHash = 0x64CA3907BFF31DA, alignRelative = false)]
    public class TkAnimMetadata : NMSTemplate
    {
        /* 0x00 */ public int FrameCount;
        /* 0x04 */ public int NodeCount;

        /* 0x08 */ public List<TkAnimNodeData> NodeData;
        /* 0x18 */ public List<TkAnimNodeFrameData> AnimFrameData;

        /* 0x28 */ public TkAnimNodeFrameData StillFrameData;
    }
}
