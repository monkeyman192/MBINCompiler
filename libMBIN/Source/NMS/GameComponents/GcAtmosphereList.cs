using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7CD6DB20A539DD3, NameHash = 0x36058B7C)]
    public class GcAtmosphereList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<VariableSizeString> Atmospheres;
    }
}
