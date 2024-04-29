using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x42FD7CAC734D9091, NameHash = 0x8CB8B180BCADFD4B)]
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector4f Values;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector4f> ExtendedValues;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 Name;
    }
}
