using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD756A38C535E82C, NameHash = 0x9488AB827ACAC6C8)]
    public class GcSyncBufferSaveDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSyncBufferSaveData> Data;
    }
}
