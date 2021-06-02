using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0x1D4D698F7CD5240A, NameHash = 0xBCF143B353D06CD3)]
    public class GcDeathQuote : NMSTemplate
    {
        public NMSString0x80 QuoteLine1;
        public NMSString0x80 QuoteLine2;
        public NMSString0x20 Author;
    }
}
