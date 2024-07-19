using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8E7B6DB16C3C8DEB, NameHash = 0x8D90EB3D)]
    public class TkProceduralModelComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<VariableSizeString> List;
    }
}
