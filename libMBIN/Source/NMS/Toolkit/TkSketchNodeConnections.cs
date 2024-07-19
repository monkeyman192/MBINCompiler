using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF4D131800E71B906, NameHash = 0xC22AB8B3)]
    public class TkSketchNodeConnections : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<uint> Connections;
    }
}
