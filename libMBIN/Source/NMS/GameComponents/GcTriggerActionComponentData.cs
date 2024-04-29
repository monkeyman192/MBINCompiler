using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97282A7EE020582A, NameHash = 0x7F5DF5820C8BDB22)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 PersistentState;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcActionTriggerState> States;
        [NMS(Index = 0)]
        /* 0x20 */ public bool HideModel;
        [NMS(Index = 6)]
        /* 0x21 */ public bool LinkStateToBaseGrid;
        [NMS(Index = 3)]
        /* 0x22 */ public bool Persistent;
        [NMS(Index = 5)]
        /* 0x23 */ public bool ResetShotTimeOnStateChange;
        [NMS(Index = 1)]
        /* 0x24 */ public bool StartInactive;
    }
}
