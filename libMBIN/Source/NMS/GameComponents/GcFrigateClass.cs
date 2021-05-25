using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x4EA913E3A4D76E25, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x6
        public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support, Normandy }
        public FrigateClassEnum FrigateClass;
    }
}