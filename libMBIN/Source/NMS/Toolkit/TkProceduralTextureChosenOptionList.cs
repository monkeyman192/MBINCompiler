using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        // list entries are aligned 0x10, not the default 0x8 todo: attribute for this!
        // this can be seen at 1402BF509 (1.0 gog), where the alignment argument is being set to 0x10
        public List<TkProceduralTextureChosenOptionSampler> Samplers; 
    }
}
