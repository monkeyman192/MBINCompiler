using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C, GUID = 0x9E500EA6450A86B2)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS( EnumType = typeof( GcAISpaceshipTypes.ShipTypeEnum ) )]
		public GcAudio3PointDopplerData[] Config;
    }
}