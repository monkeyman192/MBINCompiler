using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcTechList : NMSTemplate
    {
        public List<NMSString0x10> AvailableTech;
    }
}
