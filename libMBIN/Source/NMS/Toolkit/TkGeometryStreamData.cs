using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1D6CC846AC06B54C, NameHash = 0x40025754)]
    public class TkGeometryStreamData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
