using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
