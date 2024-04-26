using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74AF38BF3BB04A72, NameHash = 0x5CA0AF3D94711819)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureVocalSoundData> Table;
    }
}
