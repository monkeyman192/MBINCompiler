using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInteractionActivationCost : NMSTemplate
    {
        public NMSString0x10 SubstanceId;
        public List<NMSString0x10> AltIds;

        public int Cost; // might be float
        public bool Repeat;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding25;
    }
}
