using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22A2B4B052E5AF4F, NameHash = 0xCDB7AC6D11C9DF03)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TextureOptionsID;
        /* 0x10 */ public NMSString0x10 Layer;
        /* 0x20 */ public NMSString0x10 Group;
        /* 0x30 */ public List<NMSString0x20A> Options;
        /* 0x40 */ public List<NMSString0x20A> Tips;
    }
}
