using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x84, GUID = 0x5C0F8C7B61CC3821, NameHash = 0x7AC84D51C8490F18)]
    public class GcWeightedFilename : NMSTemplate
    {
        public NMSString0x80 Filename;
        public float Weight;
    }
}
