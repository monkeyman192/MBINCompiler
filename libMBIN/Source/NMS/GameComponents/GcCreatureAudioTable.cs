using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7D0676974C8E6A21, NameHash = 0x5CA0AF3D94711819)]
    public class GcCreatureAudioTable : NMSTemplate
    {
        public List<GcCreatureVocalSoundData> Table;
    }
}