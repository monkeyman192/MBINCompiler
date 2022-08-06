using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4BF39A04658FAB1, NameHash = 0xF7253E62FEA9C217)]
    public class GcAtlasSendChangeFeaturedBasesEnv : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public List<GcAtlasFeaturedBaseStateChange> BaseList;
    }
}
