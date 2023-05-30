using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        public NMSString0x10 Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }
}
