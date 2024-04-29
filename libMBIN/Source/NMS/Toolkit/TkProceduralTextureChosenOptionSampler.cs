using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA27FE2BDDA8B59A1, NameHash = 0x949DC1DF3C62FC0A)]
    public class TkProceduralTextureChosenOptionSampler : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkProceduralTextureChosenOption> Options;
    }
}
