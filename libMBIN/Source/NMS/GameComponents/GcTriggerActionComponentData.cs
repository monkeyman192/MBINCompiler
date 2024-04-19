using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x298A43DD86113262, NameHash = 0x7F5DF5820C8BDB22)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PersistentState;
        /* 0x10 */ public List<GcActionTriggerState> States;
        /* 0x20 */ public bool HideModel;
        /* 0x21 */ public bool LinkStateToBaseGrid;
        /* 0x22 */ public bool Persistent;
        /* 0x23 */ public bool ResetShotTimeOnStateChange;
        /* 0x24 */ public bool StartInactive;
    }
}
