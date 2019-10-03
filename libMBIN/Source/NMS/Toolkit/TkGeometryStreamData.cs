using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x602CB74A9031204B, NameHash = 0xA8D08B04A442318C)]
    public class TkGeometryStreamData : NMSTemplate
    {
        /* 0x00 */ public List<TkMeshData> StreamDataArray;
    }
}
