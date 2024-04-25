using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5E1C7F3BA587A759, NameHash = 0xB015A154CC664705)]
    public class TkResourceFilterData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x20A> FilteredResources;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 FilterName;
    }
}
