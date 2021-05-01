using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, Alignment = 0x8, GUID = 0x4E4C352A22680927, NameHash = 0x6EB308F16DDC755C)]
    public class GcNPCInteractiveObjectComponentData : NMSTemplate
    {
        // 0x7 entries
        public enum InteractiveObjectTypeEnum { Idle, Generic, Chair, Conversation, WatchShip, Shop, None }
        public InteractiveObjectTypeEnum InteractiveObjectType;
        public int MaxCapacity;
        public float DurationMin;
        public float DurationMax;
        public List<GcNPCInteractiveObjectState> States;
    }
}
