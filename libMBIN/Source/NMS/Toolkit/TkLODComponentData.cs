using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x112CF83927113B95, NameHash = 0x7F33053EA7D28399)]
    public class TkLODComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkLODModelResource> LODModels;
        [NMS(Index = 2)]
        /* 0x10 */ public float CrossFadeOverlap;
        [NMS(Index = 1)]
        /* 0x14 */ public float CrossFadeTime;
    }
}
