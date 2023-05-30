using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        public GcAISpaceshipTypes Type;
        public GcSpaceshipClasses Class;
        public GcPrimaryAxis Axis;
        public NMSString0x10 Weapon;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
