using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkMaterialUniform : NMSTemplate
    {
        public NMSString0x20 Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}
