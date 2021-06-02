using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, GUID = 0x89ED051FD49328DB, NameHash = 0xFAC452E6BECE8553)]
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        public NMSString0x80 Corner;
        public NMSString0x80 LineHorizontal;
        public NMSString0x80 LineVertical;

        public NMSString0x80 GlowCorner;
        public NMSString0x80 GlowLineHorizontal;
        public NMSString0x80 GlowLineVertical;
    }
}