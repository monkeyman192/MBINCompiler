using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x50, GUID = 0xE32C93208E1FC4AE, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string TypeName;
        public enum TriggerTypeEnum { Disabled, Interrupt, RunParallel, Blocked, QueueLatest, QueueAll }
        /* 0x20 */ public TriggerTypeEnum TriggerType;
        /* 0x24 */ public int SelectedVariant;
        /* 0x28 */ public int PositionX;
        /* 0x2C */ public int PositionY;
        /* 0x30 */ public TkSketchNodeConnections Connections;   // Not sure about this...
        /* 0x40 */ public List<byte> CustomData;    // This will be a byte-stream... Maybe need to finally handle this correctly...
    }
}