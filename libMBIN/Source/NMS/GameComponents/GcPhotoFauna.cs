using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8B61AD4CDD5EE012, NameHash = 0xA9CCD3801AE3DA64)]
    public class GcPhotoFauna : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public GcPhotoCreature CreatureArea;
        public bool MustBePet;
    }
}
