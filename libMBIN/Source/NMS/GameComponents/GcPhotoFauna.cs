using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x7F680BFCC6A0F3AD, NameHash = 0xA9CCD3801AE3DA64)]
    public class GcPhotoFauna : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public GcPhotoCreature CreatureArea;
    }
}
