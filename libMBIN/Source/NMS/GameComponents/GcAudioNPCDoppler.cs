using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C, GUID = 0x9E500EA6450A86B2, NameHash = 0xC02D1C8C9CF91C83)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]        // enum vals from old audio globals...
        public GcAudio3PointDopplerData[] Config;
    }
}