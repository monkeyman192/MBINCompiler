using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x84, GUID = 0xD1B4D7D91BC2E2B4, NameHash = 0x79E2609CF7F155CE)]
    public class GcCreatureGenerationDomainEntry : NMSTemplate
    {
        public GcCreatureGenerationDensity DensityModifier;
        public NMSString0x80 File;
    }
}
