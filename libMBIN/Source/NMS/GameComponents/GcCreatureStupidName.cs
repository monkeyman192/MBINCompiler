using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB254424D362E8BE7, NameHash = 0x7754E453D7160CA6)]
    public class GcCreatureStupidName : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public List<NMSString0x80> Names;
        [NMS(Index = 1)]
        /* 0x20 */ public int Count;
    }
}
