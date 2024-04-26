using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC59E7E150ECDC89B, NameHash = 0xA8D08B04A442318C)]
    public class TkGeometryStreamData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
