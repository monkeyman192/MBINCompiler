using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x42A7CE67E1CAAAA6, NameHash = 0x34A0F43E0ECB3765)]
    public class TkSketchNodeData : NMSTemplate
    {
        /* 0x00 */ public List<TkSketchNodeConnections> Connections;
        /* 0x10 */ public List<byte> CustomData;
        /* 0x20 */ public int PositionX;
        /* 0x24 */ public int PositionY;
        /* 0x28 */ public int SelectedVariant;
        // size: 0x6
        public enum TriggerTypeEnum : uint {
            Disabled,
            Interrupt,
            RunParallel,
            Blocked,
            QueueLatest,
            QueueAll,
        }
        /* 0x2C */ public TriggerTypeEnum TriggerType;
        /* 0x30 */ public NMSString0x20 TypeName;
    }
}
