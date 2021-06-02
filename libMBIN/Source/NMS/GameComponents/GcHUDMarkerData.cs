using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x180, GUID = 0x6BF046DD9D048692, NameHash = 0x73308053CF12ECFF)]
    public class GcHUDMarkerData : NMSTemplate
    {
        public NMSString0x80 Icon;
        public NMSString0x80 IconBehind;
        public NMSString0x80 Distance;
    }
}
