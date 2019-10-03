using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFDD9F1E5F1524FF4, NameHash = 0xDF429D791DD4ED76)]
    public class GcExpeditionDurationValues : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public int[] Duration;
    }
}
