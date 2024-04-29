using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B57EBC6675F56E, NameHash = 0x9488AB827ACAC6C8)]
    public class GcSyncBufferSaveDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSyncBufferSaveData> Data;
    }
}
