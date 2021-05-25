using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0000000000000000, NameHash = 0xF7253E62FEA9C217)]
    public class GcAtlasSendChangeFeaturedBasesEnv : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public List<GcAtlasFeaturedBaseStateChange> BaseList;
    }
}
