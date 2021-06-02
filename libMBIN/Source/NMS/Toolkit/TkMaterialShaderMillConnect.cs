using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x28, GUID = 0xAFF5C876E3FDFA9F, NameHash = 0xE65D6D9E5CB7E8A3)]
    public class TkMaterialShaderMillConnect : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public int Count;
        /* 0x24 */ public bool Expanded;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] EndPadding;
    }
}
