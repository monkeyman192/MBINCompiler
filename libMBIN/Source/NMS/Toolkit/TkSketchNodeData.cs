using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x50, GUID = 0xE32C93208E1FC4AE, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 TypeName;
        public enum TriggerTypeEnum { Disabled, Interrupt, RunParallel, Blocked, QueueLatest, QueueAll }
        /* 0x20 */ public TriggerTypeEnum TriggerType;
        /* 0x24 */ public int SelectedVariant;
        /* 0x28 */ public int PositionX;
        /* 0x2C */ public int PositionY;
        /* 0x30 */ public List<TkSketchNodeConnections> Connections;
        /* 0x40 */ public List<byte> CustomData;    // This is some kind of template that looks to be handled in a weird way by the exe.
        // My best guess at how it works is that depending on the value of TypeName, this data will contain different parameters.
        // Currently I won't try and RE it properly, but in the future we will want to.
    }
}