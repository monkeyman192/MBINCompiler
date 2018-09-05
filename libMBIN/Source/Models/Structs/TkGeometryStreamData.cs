using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class TkGeometryStreamData : NMSTemplate
    {
        /* 0x00 */ public List<TkMeshData> StreamDataArray;
    }
}
