using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8FF2CC2EFD8DD827, NameHash = 0xA8D08B04A442318C)]
    public class TkGeometryStreamData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
