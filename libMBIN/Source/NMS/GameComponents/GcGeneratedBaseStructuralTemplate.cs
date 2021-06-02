using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0xA4DFCECE623F5FF8, NameHash = 0x5E598DA86B66C4A9)]
    public class GcGeneratedBaseStructuralTemplate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Size = 0x20)]
        /* 0x10 */ public TkModelResource TemplateScene;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] EndPadding;
    }
}
