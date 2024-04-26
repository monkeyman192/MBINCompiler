using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB82572202B16DF66, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
