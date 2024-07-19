using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB62CABEB4137808, NameHash = 0xDE30A63F)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureVocalSoundData> Table;
    }
}
