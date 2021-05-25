using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xA9C452E692D856B7, NameHash = 0x7219E3FF7006060F)]
    public class GcFrigateFlybyOption : NMSTemplate
    {
        public GcFrigateClass FrigateClass;
        public int MinCount;
        public int MaxCount;
        public float Weight;
    }
}
