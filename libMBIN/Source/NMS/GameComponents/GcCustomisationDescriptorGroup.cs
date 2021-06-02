using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x108, GUID = 0xF0E75D8E9CE969CA, NameHash = 0x80953B08573D31B6)]
    public class GcCustomisationDescriptorGroup : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 GroupID;
        /* 0x010 */ public NMSString0x20 Title;
        /* 0x030 */ public NMSString0x80 Image;
        /* 0x0B0 */ public List<NMSString0x20> Descriptors;
        /* 0x0C0 */ public List<NMSString0x20> SuffixInclusionList;
        /* 0x0D0 */ public NMSString0x10 LinkedSpecialID;
        /* 0x0E0 */ public NMSString0x20 Tip;
        /* 0x100 */ public bool HiddenInCustomiser;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x101 */ public byte[] EndPadding;
    }
}
