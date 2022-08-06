using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF7836692C9FF6FC1, NameHash = 0x4CF465C68C10EBB4)]
    public class GcTextPreset : NMSTemplate
    {
        public GcFontTypesEnum FontType;
        public NMSTemplate TextStyle;

        public float Height;
        public Colour Colour;
    }
}