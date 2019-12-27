using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0x1D4D698F7CD5240A, NameHash = 0xBCF143B353D06CD3)]
    public class GcDeathQuote : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string QuoteLine1;
        [NMS(Size = 0x80)]
        public string QuoteLine2;
        [NMS(Size = 0x20)]
        public string Author;
    }
}
