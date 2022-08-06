using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEBBE4C04ED4FE52, NameHash = 0x6EB06F604A27BFB1)]
    public class GcScreenFilterOption : NMSTemplate
    {
        public GcScreenFilters Filter;
        public float Weight;
    }
}
