using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x4DF4F33336691325, NameHash = 0x2D2DE27512E8C450)]
    public class GcPhotoFlora : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public GcPhotoPlant PlanetType;
    }
}
