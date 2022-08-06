using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x87496EAC56E59CCC, NameHash = 0x53B11FA3B3AD5912)]
    public class TkSketchNodeConnections : NMSTemplate
    {
        /* 0x0 */ public List<int> Connections;
        // It is an int in the data, but doesn't appear as a List<int> in the exe.
        // My guess is that it's the index of the object in the list of nodes.
    }
}