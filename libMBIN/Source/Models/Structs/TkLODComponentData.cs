using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class TkLODComponentData : NMSTemplate
    {
        /* 0x10 */ public List<TkLODModelResource> LODModel;
        /* 0x10 */ public float CrossFadeTime;
        /* 0x14 */ public float CrossFadeOverlap;
    }
}
