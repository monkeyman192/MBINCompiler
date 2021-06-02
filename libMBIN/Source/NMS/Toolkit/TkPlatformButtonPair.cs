using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0xE2FDB3256F6FF4CD, NameHash = 0xC728D4342BAC4AC8)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        public NMSString0x10 PlatformId;
        public NMSString0x10 ButtonId;
        public Vector2f Size;
    }

}