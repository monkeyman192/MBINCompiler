using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DBEC1C7E7AE88DF, NameHash = 0x27475417)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienSpeechEntry> Table;
    }
}
