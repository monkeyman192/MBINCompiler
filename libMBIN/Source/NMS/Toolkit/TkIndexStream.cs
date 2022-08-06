using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x0C3F2CB3BC1F3270, NameHash = 0x4E6048B326CC903A)]
    public class TkIndexStream : NMSTemplate
    {
        /* 0x0 */ public List<int> IndexStream;
    }
}
