using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58585E16D68D56C2, NameHash = 0x85DDBDB8)]
    public class GcSyncBufferSaveDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSyncBufferSaveData> Data;
    }
}
