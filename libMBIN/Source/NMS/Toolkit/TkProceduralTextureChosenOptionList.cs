using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9CBF978FCC7BFB1D, NameHash = 0x9B37197A)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
