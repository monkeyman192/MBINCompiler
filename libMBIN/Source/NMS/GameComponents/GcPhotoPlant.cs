using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x820E799003AAABBF, NameHash = 0xEFC8FCE1F6004590)]
    public class GcPhotoPlant : NMSTemplate
    {
		public enum PhotoPlantTypeEnum { Sodium, Oxygen, PluePlant }
		public PhotoPlantTypeEnum PhotoPlantType;
    }
}