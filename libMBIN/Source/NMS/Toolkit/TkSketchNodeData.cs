using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAA9CB567C1399AE8, NameHash = 0xFB59D917)]
    public class TkSketchNodeData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<TkSketchNodeConnections> Connections;
        [NMS(Index = 6)]
        /* 0x10 */ public List<byte> CustomData;
        [NMS(Index = 3)]
        /* 0x20 */ public int PositionX;
        [NMS(Index = 4)]
        /* 0x24 */ public int PositionY;
        [NMS(Index = 2)]
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
        [NMS(Index = 1)]
        /* 0x2C */ public TriggerTypeEnum TriggerType;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x20 TypeName;
    }
}
