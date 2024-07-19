using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x626881BBBDC689EF, NameHash = 0xBE05474C)]
    public class TkResourceFilterList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceFilterData> Filters;
    }
}
