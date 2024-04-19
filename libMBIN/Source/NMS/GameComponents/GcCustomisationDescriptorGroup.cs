using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E931346CFC5A9A5, NameHash = 0x80953B08573D31B6)]
    public class GcCustomisationDescriptorGroup : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Tip;
        /* 0x020 */ public NMSString0x20A Title;
        /* 0x040 */ public List<NMSString0x20> Descriptors;
        /* 0x050 */ public NMSString0x10 GroupID;
        /* 0x060 */ public NMSString0x10 LinkedSpecialID;
        /* 0x070 */ public List<NMSString0x20> SuffixInclusionList;
        /* 0x080 */ public NMSString0x80 Image;
        /* 0x100 */ public bool HiddenInCustomiser;
    }
}
