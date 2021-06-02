using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0xA8, GUID = 0xB3867276182069C1, NameHash = 0xB49AE407F95DCEE4)]
    public class TkMaterialAlternative : NMSTemplate
    {
        public enum TextureTypeEnum { Diffuse, Normal, Ambient, Environment }
        /* 0x00 */ public TextureTypeEnum TextureType;
        /* 0x04 */ public NMSString0x80 File;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        /* 0x88 */ public NMSString0x20 MaterialAlternativeId;
    }
}
