using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF4D131800E71B906, NameHash = 0x53B11FA3B3AD5912)]
    public class TkSketchNodeConnections : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<uint> Connections;
    }
}
