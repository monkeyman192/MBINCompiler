using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x27E2B5892D2FE3C5, NameHash = 0x6597D4E975E02DA7)]
    public class GcMissionConditionRefinerHasOutput : NMSTemplate
    {
        public NMSString0x10 OutputProduct;
        public int OutputAmount;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
