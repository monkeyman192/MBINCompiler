using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA89E4375F2F622BB, NameHash = 0x2C2099DE)]
    public class TkMaterialUniform : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector4f Values;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector4f> ExtendedValues;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Name;
    }
}
