using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7CD6DB20A539DD3, NameHash = 0x594FCBE47D02F5DF)]
    public class GcAtmosphereList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Atmospheres;
    }
}
