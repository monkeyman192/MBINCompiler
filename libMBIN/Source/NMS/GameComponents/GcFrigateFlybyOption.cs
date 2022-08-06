using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF47A2A409E1D516, NameHash = 0x7219E3FF7006060F)]
    public class GcFrigateFlybyOption : NMSTemplate
    {
        public GcFrigateClass FrigateClass;
        public int MinCount;
        public int MaxCount;
        public float Weight;
    }
}
