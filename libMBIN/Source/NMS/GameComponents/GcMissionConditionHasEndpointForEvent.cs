using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x98657E8C7DFA59B6, NameHash = 0x9C35F879928BF0CE)]
    public class GcMissionConditionHasEndpointForEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string EventID;
        public float MaxDistance;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
