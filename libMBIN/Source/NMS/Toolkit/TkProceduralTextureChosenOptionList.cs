using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x78E395C610366630, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        public List<TkProceduralTextureChosenOptionSampler> Samplers; 
    }
}
