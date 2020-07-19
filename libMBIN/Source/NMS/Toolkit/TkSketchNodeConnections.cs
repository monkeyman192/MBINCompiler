using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x87496EAC56E59CCC, NameHash = 0x53B11FA3B3AD5912)]
    public class TkSketchNodeConnections : NMSTemplate
    {
        /* 0x0 */ public List<TkMaterialSketchConnect> Connections;  // not sure about this...
    }
}