using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC7F1B8F3E183559, NameHash = 0x7F5DF5820C8BDB22)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        /* 0x00 */ public bool HideModel;
        /* 0x01 */ public bool StartInactive;
        /* 0x08 */ public List<GcActionTriggerState> States;
        /* 0x18 */ public bool Persistent;
        /* 0x20 */ public NMSString0x10 PersistentState;
        /* 0x30 */ public bool ResetShotTimeOnStateChange;
        /* 0x31 */ public bool LinkStateToBaseGrid;
    }
}
