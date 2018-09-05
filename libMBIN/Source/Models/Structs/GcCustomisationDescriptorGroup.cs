using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xE0)]
    public class GcCustomisationDescriptorGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string GroupID;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Title;
        [NMS(Size = 0x80)]
        /* 0x30 */ public string Image;
        /* 0xB0 */ public List<NMSString0x20> Descriptors;
        /* 0xC0 */ public List<NMSString0x20> SuffixInclusionList;
        [NMS(Size = 0x10)]
        /* 0xD0 */ public string LinkedSpecialID;
    }
}
