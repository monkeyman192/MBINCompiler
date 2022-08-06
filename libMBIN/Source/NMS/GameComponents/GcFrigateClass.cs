using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADC2716BE63D089D, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x8
        public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support, Normandy, DeepSpace, DeepSpaceCommon }
        public FrigateClassEnum FrigateClass;
    }
}