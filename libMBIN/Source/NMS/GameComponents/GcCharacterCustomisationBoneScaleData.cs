using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x608078A388EF854B, NameHash = 0xFF61F85ED8456D83)]
    public class GcCharacterCustomisationBoneScaleData : NMSTemplate
    {
        public NMSString0x10 BoneName;
        public float Scale;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
