using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3317E7A729576553, NameHash = 0xF47FD4328A49A000)]
    public class GcPlayerConflictData : NMSTemplate
    {
        // size: 0x4
        public enum ConflictLevelEnum { Low, Default, High, Pirate }
        /* 0x0 */ public ConflictLevelEnum ConflictLevel;
    }
}
