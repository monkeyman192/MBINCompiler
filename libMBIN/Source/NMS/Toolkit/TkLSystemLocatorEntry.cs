using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemLocatorEntry : NMSTemplate // 0x98 bytes
    {
        public NMSString0x80 Model;

        public float Probability;
        public List<TkLSystemRestrictionData> Restrictions;
    }
}
