using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x38835CA9D5770C34, NameHash = 0x8CB8B180BCADFD4B)]
    public class TkMaterialUniform : NMSTemplate
    {
        /* 0x00 */ public Vector4f Values;
        /* 0x10 */ public List<Vector4f> ExtendedValues;
        /* 0x20 */ public NMSString0x20 Name;
    }
}
