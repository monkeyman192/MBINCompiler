using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE2FDB3256F6FF4CD, NameHash = 0xC728D4342BAC4AC8)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PlatformId;
        [NMS(Size = 0x10)]
        public string ButtonId;
        public Vector2f Size;
    }

}
