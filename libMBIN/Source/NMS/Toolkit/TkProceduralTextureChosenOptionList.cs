using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDD3D858AF81CDAFB, NameHash = 0x9B37197A)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
