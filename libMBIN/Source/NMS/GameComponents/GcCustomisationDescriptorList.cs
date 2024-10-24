using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA851C6596FF18EB0, NameHash = 0x68644DA4)]
    public class GcCustomisationDescriptorList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x20> Descriptors;
    }
}