using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B264442EE516B09, NameHash = 0xCC5FB6577E4B6B47)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienSpeechEntry> Table;
    }
}
