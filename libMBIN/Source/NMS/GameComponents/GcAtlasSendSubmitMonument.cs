using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1D0, GUID = 0xAEBC854578DE6E33, NameHash = 0xF4282F250D0EEBDB)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x000 */ public byte[] Padding0;
        /* 0x008 */ public ulong ClientUserdata;
        /* 0x010 */ public GcAtlasMonument Monument;
        // size: 0x2
        public enum MonumentRoleEnum { Creator, CoCreator }
        /* 0x1A0 */ public MonumentRoleEnum MonumentRole;
        /* 0x1A4 */ public NMSString0x20 OtherUser;
    }
}
