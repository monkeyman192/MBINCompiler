using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, Alignment = 0x10, GUID = 0xD4B7DD6169DC478, NameHash = 0x8CB8B180BCADFD4B)]
    public class TkMaterialUniform : NMSTemplate
    {
        public NMSString0x20 Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}