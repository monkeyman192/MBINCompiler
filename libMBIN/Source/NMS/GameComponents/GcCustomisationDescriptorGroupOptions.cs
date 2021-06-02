using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x99DF37CCC96BB816, Alignment = 0x8, NameHash = 0x57CBFDF164E923E9)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 GroupTitle;
        /* 0x20 */ public bool FirstOptionIsEmpty;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        /* 0x28 */ public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
        /* 0x38 */ public List<NMSString0x10> PrerequisiteGroup;
    }
}
