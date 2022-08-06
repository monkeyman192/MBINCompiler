using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98657E8C7DFA59B6, NameHash = 0x9C35F879928BF0CE)]
    public class GcMissionConditionHasEndpointForEvent : NMSTemplate
    {
        public NMSString0x20A EventID;
        public float MaxDistance;
    }
}
