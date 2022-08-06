using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x067E627F1BDA6FC4, NameHash = 0x81F6791F9BCCAB59)]
    public class GcAtlasSendRemoveFeaturedBases : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public List<GcAtlasFeaturedBaseStateChange> BaseList;
    }
}
