using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkResourceFilterData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string FilterName;
        public List<NMSString0x20> FilteredResources;

    }
}
