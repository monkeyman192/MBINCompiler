using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0xF7836692C9FF6FC1, NameHash = 0x4CF465C68C10EBB4)]
    public class GcTextPreset : NMSTemplate
    {
        public GcFontTypesEnum Font;
        public NMSTemplate Style;

        public float Height;
        public Colour Colour;
    }
}