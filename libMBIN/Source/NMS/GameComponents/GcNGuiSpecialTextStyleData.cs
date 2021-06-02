using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x52ECDFFDB4B7B1CD, NameHash = 0x9C498422BDBE21FE)]
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        public NMSString0x10 Name;

        public List<NMSTemplate> StyleProperties;
        public GcNGuiStyleAnimationData Animation;
    }
}
