using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSelectableObjectList : NMSTemplate
    {
        public NMSString0x10 Name;
        public GcAlienRace Race;
        public List<GcSelectableObjectData> Options;
    }
}
