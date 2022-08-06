using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8B913442E7E83049, NameHash = 0x1667364CB586EB42)]
    public class GcBootLogoData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x000 */ public NMSString0x100[] Textures;
        [NMS(Size = 0x4)]
        /* 0x400 */ public float[] DisplayTime;
    }
}