using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x46FCEC77586D3A74, NameHash = 0x11D01E37)]
    public class TkResourceFilterData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x20A> FilteredResources;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 FilterName;
    }
}
