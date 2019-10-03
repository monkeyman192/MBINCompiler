using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x10, GUID = 0xD4B7DD6169DC478, NameHash = 0x8CB8B180BCADFD4B)]
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }
}
