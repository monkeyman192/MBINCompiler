using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9777486713E25BA7, NameHash = 0x949DC1DF3C62FC0A)]
    public class TkProceduralTextureChosenOptionSampler : NMSTemplate
    {
        public List<TkProceduralTextureChosenOption> Options;
    }
}
