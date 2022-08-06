using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8197B1FE02D326A0, NameHash = 0xF9391B96F83DAF40)]
    public class GcCustomisationBackpackData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 NodeName;
        /* 0x20 */ public Vector3f ActiveJetOffset;
    }
}
