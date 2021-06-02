using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2A8, GUID = 0x3558F692031D58C, NameHash = 0x91CAC70AC2792E2A)]
    public class GcResourceElement : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Filename;
        [NMS(Size = 8, Ignore = true)]
        /* 0x080 */ public byte[] Padding80;
        /* 0x088 */ public GcSeed Seed;
        /* 0x098 */ public NMSString0x200 AltId;
        /* 0x298 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
    }
}
