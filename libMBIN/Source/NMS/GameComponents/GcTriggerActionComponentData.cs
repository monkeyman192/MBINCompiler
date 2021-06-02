using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x38, GUID = 0xEC7F1B8F3E183559, NameHash = 0x7F5DF5820C8BDB22)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        /* 0x00 */ public bool HideModel;
        /* 0x01 */ public bool StartInactive;
        [NMS(Size = 0x6, Ignore =true)]
        /* 0x02 */ public byte[] Padding2;
        /* 0x08 */ public List<GcActionTriggerState> States;
        /* 0x18 */ public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        /* 0x19 */ public byte[] Padding19;
        /* 0x20 */ public NMSString0x10 PersistentState;
        /* 0x30 */ public bool ResetShotTimeOnStateChange;
        /* 0x31 */ public bool LinkStateToBaseGrid;
        [NMS(Size = 6, Ignore = true)]
        /* 0x32 */ public byte[] EndPadding;
    }
}
